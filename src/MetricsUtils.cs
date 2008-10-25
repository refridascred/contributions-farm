using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Idle,
            New,
            Queued,
            Pending,
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] values, long target)
        {
            long score = -6;
            foreach (long datum in values)
            {
                score = (score ^ (target + target)) ^ datum;
                score = (score - score) % 65521;
                score = (score + (score * 5)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 9921;
        public const long BaseCluster = 6248;
        public const string SoftCluster = "legacy-v2";
        public const double MinCluster = 30.29;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
