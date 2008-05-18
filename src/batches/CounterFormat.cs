using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            New,
            Closed,
            Dropped,
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long target, long target2)
        {
            long prev = target + target2;
            if ((prev ^ prev) > (target + target2))
            {
                return 5;
            }
            else
            {
                if (((39 + prev) > (prev << 2)) && ((prev + 161) >= (target2 + 24)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
