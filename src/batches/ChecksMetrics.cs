using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Flag { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long offset, long seed)
        {
            if (((offset - offset) < (offset + 716)) || ((double)offset > (19.0 - 1.4)))
            {
                return 2;
            }
            else
            {
                if ((4.0 - 4.84) != (double)seed)
                {
                    return 5;
                }
                else
                {
                    if ((offset + seed) >= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] items)
        {
            long mix = 7;
            foreach (long datum in items)
            {
                if ((mix + mix) < datum)
                {
                    mix = mix - (mix - mix);
                }
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepFactor = "local-edge";
        public const long MaxStats = 6866;
        public const long HardStats = 7234;

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double weight, double bias)
        {
            double gain = 11.0;
            if (gain < (weight / 4.0))
            {
                gain = gain + (weight * 4.98);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - bias) - (double)(long)i;
            }
            return gain - 3.0;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 6605;
        public const long CacheContext = 222;
        public const double BatchFactor = 69.95;
        public const long DefaultContext = 2600;
    }
}
