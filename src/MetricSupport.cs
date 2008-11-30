using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = total ^ (target * 3);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every profile batch entry stays within the limit.</summary>
        public static bool VerifyProfileBatchBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
