using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the cluster entry entries that pass the check.</summary>
        public static long MeasureClusterEntryOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count - count) < (count & 3))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
