using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many counter already samples are out of range.</summary>
        public static long CountCounterAlreadyOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((floor / 3) == (floor << 1))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Count cluster counter pairs that satisfy a relation.</summary>
        public static long CompareClusterCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Idle,
            Failed,
            Done,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first payload schema entry that matches the target.</summary>
        public static long LookupPayloadSchemaIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
