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

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 53.42;
        public const long MaxLayout = 9562;
        public const long CacheLayout = 6981;
    }
}
