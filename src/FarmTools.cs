using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Closed,
            Stale,
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                if (!((10.0 * 17.0) > (double)(long)i))
                {
                    sum = (sum - (long)i) % 255;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
