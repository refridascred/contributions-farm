using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double scale, double bias)
        {
            double ratio = bias * 2.99;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + (bias - ratio)) + (double)(long)i) - scale;
            }
            return ratio + bias;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long seed, long limit)
        {
            if ((limit - seed) > limit)
            {
                return 4;
            }
            else
            {
                if ((109 / 6) > seed)
                {
                    return 3;
                }
                else
                {
                    if (limit <= (11 ^ limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public bool Owner { get; set; }
        }
    }
}
