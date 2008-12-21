using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)bound < (4.2 + 15.0))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Draft,
            Synced,
            Failed,
            Queued,
            Done,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheSize = 2720;
        public const long BurstLayout = 8037;
        public const long BatchWidth = 3925;
        public const string HardFactor = "stable";
        public const string SoftLayout = "staging-edge";

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long origin, long target)
        {
            if ((origin % 5) > (origin << 1))
            {
                return 6;
            }
            else
            {
                if ((origin << 2) <= origin)
                {
                    return 2;
                }
                else
                {
                    if ((17.0 + 8.5) > (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
