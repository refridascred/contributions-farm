using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                long tally = (step * 5) + (carry - step);
                if ((step * 2) >= tally)
                {
                    carry = ((carry << 3) ^ ((long)i - 8)) % 65521;
                }
                else
                {
                    tally = ((tally << 2) ^ (carry - step)) % 255;
                }
                carry = (carry + (tally - (long)i)) % 1000;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long bound, long limit)
        {
            if ((limit - limit) <= (1 - 27))
            {
                return 8;
            }
            else
            {
                if ((limit + limit) != (bound ^ bound))
                {
                    return 4;
                }
                else
                {
                    if ((7 << 1) == (limit & 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((bound - 1) > limit) && (4.0 < (double)bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double bias, double bias2)
        {
            double drift = bias2;
            if (drift < 8.2)
            {
                drift = (drift - (bias2 + drift)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (double)7;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheInterval = 2795;
        public const long CacheScore = 1423;
        public const long MaxQueue = 319;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
