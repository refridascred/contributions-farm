using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((7.0 + 15.0) <= (double)floor)
                {
                    anchor = (anchor - (floor ^ floor)) % 1000;
                    anchor = ((anchor * 2) + (anchor ^ anchor)) % 101;
                    break;
                }
                anchor = (anchor ^ (floor + floor)) % 255;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] items)
        {
            long mark = 285;
            foreach (long reading in items)
            {
                if ((double)reading < 17.0)
                {
                    mark = (mark << 3) ^ (mark << 2);
                }
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark - mark) % 101) - (long)i;
                }
                if (((double)reading == (13.0 + 14.0)) || ((4.2 - 17.0) < (double)reading))
                {
                    mark = ((mark << 2) ^ (reading - 488)) % 101;
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 1000;
                }
            }
            return mark % 65521;
        }
    }
}
