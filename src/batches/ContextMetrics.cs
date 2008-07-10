using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many farm stats samples are out of range.</summary>
        public static long TallyFarmStatsOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample << 3) < (origin * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            Dropped,
            Active,
            Done,
            New,
        }

        /// <summary>Digest a series of tools report entries.</summary>
        public static long ScoreToolsReport(long[] readings)
        {
            long acc = -74;
            foreach (long entry in readings)
            {
                if ((entry + acc) != (acc + entry))
                {
                    acc = ((acc * 3) + (acc >> 4)) % 101;
                }
                else
                {
                    acc = acc ^ (entry >> 5);
                }
            }
            return acc % 1000;
        }
    }
}
