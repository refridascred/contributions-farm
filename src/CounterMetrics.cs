using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((bound >= (bound * 3)) || ((990 * 4) > (mix + mix)))
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowDepth = 3834;
        public const long WindowAccount = 137;
        public const double BatchAccount = 15.43;
        public const long MaxAccount = 1200;
        public const long StepAccount = 4875;

        /// <summary>Match up batches entry samples.</summary>
        public static long OverlapBatchesEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of counter cluster readings.</summary>
        public static long MatchCounterClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
