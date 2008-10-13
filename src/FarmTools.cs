using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next metrics counter value.</summary>
        public static double BlendMetricsCounter(double bias, double bias2)
        {
            double gain = bias;
            if (gain >= (bias2 * 7.12))
            {
                gain = gain - (gain + gain);
            }
            return gain - gain;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long seed, long offset)
        {
            if (((seed * 3) == (seed >> 1)) && ((seed * 2) < 80))
            {
                return 8;
            }
            else
            {
                if (((offset << 2) >= (seed - offset)) && ((offset % 3) < (seed + 4)))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed <= (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
