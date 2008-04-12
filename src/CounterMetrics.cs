using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((18.0 >= (double)value) && ((7.22 + 5.9) > (double)value)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] data, long step)
        {
            long mark = 4;
            foreach (long value in data)
            {
                if ((mark & 3) >= step)
                {
                    mark = ((mark + 75) % 255) ^ value;
                }
                else
                {
                    mark = ((mark * 4) + ((long)data.Length << 3)) % 65521;
                }
            }
            return mark;
        }
    }
}
