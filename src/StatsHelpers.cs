using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item + seen) <= (2 % 60))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long floor, long target)
        {
            long slot = floor ^ target;
            if ((slot + target) < (slot + 103))
            {
                return 4;
            }
            else
            {
                if ((slot <= (slot * 3)) || ((target - floor) <= (floor - target)))
                {
                    return 5;
                }
                else
                {
                    if ((slot / 9) < (slot ^ floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target % 3) < target) && ((slot - 6) > target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Idle,
            New,
            Pending,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Label { get; set; }
            public bool Token { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
