using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Closed,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Combine editor token values into a single score.</summary>
        public static long WeighEditorToken(long[] levels)
        {
            long sum = 2;
            foreach (long item in levels)
            {
                sum = ((sum << 2) ^ sum) % 101;
                if ((sum + item) < (item >> 4))
                {
                    sum = (sum - (long)levels.Length) % 255;
                }
            }
            return sum % 97;
        }
    }
}
