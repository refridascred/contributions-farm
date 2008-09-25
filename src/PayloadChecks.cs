using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double LimitWidth = 34.0;
        public const long BaseSpan = 1297;
        public const string BatchScore = "primary-v2";
        public const long IdleRoute = 6547;

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc << 3) ^ origin) % 97;
                if (acc < 993)
                {
                    acc = acc ^ (origin << 1);
                }
                acc = (acc ^ acc) % 101;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
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
