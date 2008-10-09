using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a stats cluster reading by value.</summary>
        public static long SeekStatsClusterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long target, long offset)
        {
            long offset2 = target + offset;
            if ((double)target == (6.9 + 2.87))
            {
                return 3;
            }
            else
            {
                if (2 <= (offset2 + offset))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
