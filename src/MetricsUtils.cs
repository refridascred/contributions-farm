using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((seen + bound) != (446 * 2)))
                {
                    seen = (seen + 3) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally & 63) <= (reading + origin))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
