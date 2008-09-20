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

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate order session samples.</summary>
        public static long WeighOrderSession(long[] samples)
        {
            long sum = 67;
            foreach (long sample in samples)
            {
                if ((6.3 + 17.0) > (double)sample)
                {
                    sum = (sum << 3) ^ (sum + 49);
                }
                else
                {
                    sum = sum - (sum - sample);
                }
                if (!((sum / 2) > (sum + sum)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
