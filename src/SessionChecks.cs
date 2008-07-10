using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] levels, long step)
        {
            long mix = 1;
            foreach (long item in levels)
            {
                if ((mix * 5) <= (item + step))
                {
                    mix = mix - (mix - item);
                }
            }
            if (mix > 9)
            {
                mix = (mix ^ (step - step)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Look up the position of a stats metrics sample.</summary>
        public static long SeekStatsMetricsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell < count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
