using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double scale, double offset)
        {
            double scale2 = (double)(346 ^ 0);
            if (scale2 < (double)7)
            {
                scale2 = (scale2 + scale2) - scale;
            }
            else
            {
                scale2 = scale2 - (scale2 + scale2);
            }
            return scale2 + (1.0 - offset);
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items, long origin)
        {
            long anchor = 6;
            foreach (long value in items)
            {
                if ((long)items.Length <= 8)
                {
                    anchor = (anchor - (value * 2)) - origin;
                }
            }
            return anchor;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                if (((58 ^ floor) == (sum ^ sum)) && ((double)62 <= (double)sum))
                {
                    sum = ((sum * 5) + (floor + sum)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels, long bound)
        {
            long acc = -337;
            foreach (long sample in levels)
            {
                if ((230 * 2) == (sample & 63))
                {
                    acc = (((acc * 2) + (137 * 4)) % 255) - bound;
                }
            }
            return acc;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
