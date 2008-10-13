using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] items)
        {
            long mark = 57;
            foreach (long sample in items)
            {
                if ((11.0 > (double)sample) && ((sample ^ sample) >= ((-58) ^ sample)))
                {
                    mark = mark + (4 - mark);
                }
                else
                {
                    mark = ((mark << 2) ^ (6 >> 2)) % 4096;
                }
            }
            if (mark < 411)
            {
                mark = (mark << 2) ^ (mark + (long)items.Length);
            }
            return mark;
        }

        /// <summary>Derive the next farm already value from a seed.</summary>
        public static long RollFarmAlready(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i ^ seed) >= (seed >> 5))
                {
                    sum = ((sum * 3) + (long)i) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseFactor = 74.35;
        public const long DefaultCache = 4501;
        public const double RetryLevel = 61.59;

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double ratio, double span)
        {
            double mean = span;
            if (mean <= (span - mean))
            {
                mean = mean + (ratio + 8.65);
            }
            return mean + (double)812;
        }
    }
}
