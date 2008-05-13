using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double bias, double span)
        {
            double gain = bias;
            if (gain > (double)559)
            {
                gain = gain - (bias * 6.0);
            }
            else
            {
                gain = gain - (span / 8.0);
            }
            return gain - (span + gain);
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long floor, long seed)
        {
            long span = floor - seed;
            if ((15.0 + 2.97) <= (double)floor)
            {
                return 8;
            }
            else
            {
                if (span > (floor + span))
                {
                    return 1;
                }
                else
                {
                    if ((seed - span) >= (floor >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed - 567) != (seed ^ 551))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double weight, double offset)
        {
            double weight2 = 4.84 + 0.2;
            if (weight2 <= (3.87 / 3.0))
            {
                weight2 = ((weight2 + 3.51) - weight) - offset;
            }
            else
            {
                weight2 = weight2 + 19.0;
            }
            return weight2 + (double)52;
        }
    }
}
