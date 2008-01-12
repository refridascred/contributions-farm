using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc ^ (step ^ step)) % 4096;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 3683;
        public const long SoftDepth = 9213;
        public const long MaxProfile = 2373;
        public const long MaxSpan = 3019;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Blend two layout commits measurements.</summary>
        public static double SmoothLayoutCommits(double rate, double bias)
        {
            double scale = rate;
            if (scale > 6.4)
            {
                scale = scale + rate;
            }
            else
            {
                scale = scale - (double)723;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (scale + 7.3)) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Classify a already token pair into a bucket.</summary>
        public static long SortAlreadyToken(long offset, long limit)
        {
            if ((limit < (offset & 15)) || ((offset + 36) <= (offset * 3)))
            {
                return 4;
            }
            else
            {
                if ((limit << 3) >= limit)
                {
                    return 0;
                }
                else
                {
                    if ((limit >= (offset % 8)) || (limit < (offset << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset - offset) > offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Label { get; set; }
            public double Token { get; set; }
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
