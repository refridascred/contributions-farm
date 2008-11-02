using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the window order series from a seed.</summary>
        public static long DeriveWindowOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((limit - limit) <= (mix << 2))
                {
                    break;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] levels, long floor)
        {
            long anchor = 33;
            foreach (long entry in levels)
            {
                if (((anchor + 655) >= (6 + 7)) && ((3 / 2) != (floor - entry)))
                {
                    anchor = (anchor + ((-200) & 3)) % 97;
                }
            }
            if (anchor > 74)
            {
                anchor = ((anchor * 5) + (anchor ^ anchor)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
