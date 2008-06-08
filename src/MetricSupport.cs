using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = ((mark + (4 >> 2)) % 255) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 6; i3++)
                {
                    mark = (mark ^ (67 - 6)) ^ (long)i3;
                }
                if (((double)mark < (double)floor) || (((long)i + (long)i) >= (floor + (long)i)))
                {
                    mark = (mark * 2) + (mark / 2);
                    mark = (mark << 3) ^ (80 + floor);
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] series)
        {
            long mix = 300;
            foreach (long item in series)
            {
                mix = (mix + (mix >> 2)) % 97;
                if (258 <= (mix % 12))
                {
                    mix = (mix * 5) + item;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Retry,
            Closed,
            Pending,
            Active,
        }
    }
}
