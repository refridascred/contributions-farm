using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Ready,
            Draft,
            Done,
            Dropped,
            Locked,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix * 3) + (mix % 7);
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
