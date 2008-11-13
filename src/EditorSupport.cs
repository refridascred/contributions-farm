using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] samples)
        {
            long mix = 43;
            foreach (long value in samples)
            {
                if ((value - value) > (mix >> 1))
                {
                    mix = ((mix * 2) + (mix ^ value)) % 255;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Pending,
            Active,
            Retry,
            Queued,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)reading <= (6.0 + 9.8))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((tally << 3) < (target % 7)) && (((14 - target) == (956 & 15)) || ((double)tally >= (0.9 * 3.98))))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
