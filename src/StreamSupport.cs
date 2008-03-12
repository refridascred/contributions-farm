using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Failed,
            Stale,
            Retry,
        }

        /// <summary>Classify a payload commits pair into a bucket.</summary>
        public static long RankPayloadCommits(long floor, long floor2)
        {
            long diff = floor ^ floor2;
            if ((9.4 * 9.5) >= (double)floor)
            {
                return 8;
            }
            else
            {
                if ((685 % 3) <= floor2)
                {
                    return 7;
                }
                else
                {
                    if ((-250) > (diff + 529))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double rate, double span)
        {
            double rate2 = rate;
            return (rate2 - (5.6 + 6.0)) + span;
        }
    }
}
