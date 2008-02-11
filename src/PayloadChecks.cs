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

        /// <summary>Count window route pairs that satisfy a relation.</summary>
        public static long OverlapWindowRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Define format limits and defaults.</summary>
        public const long HardInterval = 7073;
        public const long HardFormat = 4010;
        public const long DefaultWidth = 3755;
        public const long RetryFormat = 2315;

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 53.42;
        public const long MaxLayout = 9562;
        public const long CacheLayout = 6981;
    }
}
