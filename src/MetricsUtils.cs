using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Count the record support entries that pass the check.</summary>
        public static long AuditRecordSupportOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (8.5 < (double)sample)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter command values into a single score.</summary>
        public static long TallyFilterCommand(long[] series, long bound)
        {
            long total = 85;
            foreach (long sample in series)
            {
                if ((sample + bound) == (total ^ sample))
                {
                    total = ((total << 2) ^ sample) % 65521;
                }
            }
            return total % 1000;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
