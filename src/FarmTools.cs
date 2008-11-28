using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of cache farm readings.</summary>
        public static long WeighCacheFarm(long[] samples, long target)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                mix = (mix - (mix & 3)) % 65521;
                if ((target << 2) == (mix - sample))
                {
                    mix = mix - (target ^ 76);
                }
                if ((target + 739) > (mix * 2))
                {
                    mix = (mix << 3) ^ (target & 255);
                }
            }
            return mix;
        }

        /// <summary>Validate filter entry readings against a bound.</summary>
        public static bool CheckFilterEntryRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a window queue sample.</summary>
        public static long SeekWindowQueueIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
