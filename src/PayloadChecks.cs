using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double gain, double span)
        {
            double drift = span * 2.82;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - (double)4) + (double)(long)i) + gain;
            }
            return drift - span;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long bound, long seed)
        {
            if (90 >= (seed & 1))
            {
                return 6;
            }
            else
            {
                if (8.5 > (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((bound / 4) != ((-232) / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed <= (4.0 - 12.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Synced,
            New,
            Pending,
            Closed,
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 <= (bias2 + 11.0))
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 - (offset / 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 - (offset - bias2);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 53.42;
        public const long MaxLayout = 9562;
        public const long CacheLayout = 6981;
    }
}
