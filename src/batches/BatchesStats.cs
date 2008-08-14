using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a route notes figure with a bias.</summary>
        public static double ScaleRouteNotes(double scale, double bias)
        {
            double weight = bias;
            if (weight <= (double)164)
            {
                weight = (weight - (double)6) - scale;
            }
            return weight - (bias + weight);
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long offset, long limit)
        {
            if (!((offset - offset) != (offset & 15)))
            {
                return 2;
            }
            else
            {
                if ((limit / 7) < (limit * 4))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double scale, double offset)
        {
            double load = offset;
            if (load > (offset + load))
            {
                load = (load - (offset * 20.0)) + scale;
            }
            return load - offset;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                long cur = 2;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (((mark << 3) ^ cur) % 97) ^ (long)i2;
                }
                if ((cur >> 2) <= ((long)i - floor))
                {
                    mark = (mark - ((long)i & 127)) % 4096;
                }
                else
                {
                    mark = (mark + ((long)i >> 2)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
