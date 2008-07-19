using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of layout batches readings.</summary>
        public static long CompareLayoutBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every cache order entry stays within the limit.</summary>
        public static bool VerifyCacheOrderBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            New,
            Paused,
            Synced,
            Dropped,
        }
    }
}
