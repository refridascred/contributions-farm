using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long step, long bound)
        {
            if (((3.54 + 4.19) == (double)bound) && ((step << 2) > (1 >> 4)))
            {
                return 2;
            }
            else
            {
                if ((bound >= (bound >> 1)) || ((839 & 63) <= bound))
                {
                    return 7;
                }
                else
                {
                    if ((step >> 3) == (step + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (15.0 < (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double weight, double bias)
        {
            double weight2 = bias + weight;
            if (weight2 <= weight)
            {
                weight2 = weight2 - (double)7;
            }
            return weight2 + 9.3;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Level { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
