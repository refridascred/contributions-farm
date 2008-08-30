using System;

namespace Common.Utilities
{
    /// <summary>Route metrics helpers.</summary>
    public static class RouteMetrics
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] series, long limit)
        {
            long mark = -513;
            foreach (long sample in series)
            {
                if ((sample + limit) < (mark + limit))
                {
                    mark = ((mark << 2) ^ sample) % 4096;
                }
                if ((double)519 <= (double)mark)
                {
                    break;
                }
            }
            if (mark < (-74))
            {
                mark = (mark - 263) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 9138;
        public const long SoftBudget = 9532;
        public const long BatchInterval = 5920;
        public const long LimitSession = 8323;
        public const string DefaultWidth = "strict-v2";

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long origin, long limit)
        {
            long diff = origin + limit;
            if (((-69) * 4) == (origin - diff))
            {
                return 4;
            }
            else
            {
                if ((origin % 8) != (limit ^ diff))
                {
                    return 3;
                }
                else
                {
                    if (!((limit * 3) > (origin % 8)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor ^ (201 - floor)) % 255;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 56.15;
        public const string MaxWidth = "latest-v2";
        public const string DefaultToken = "latest";

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] data, long limit)
        {
            long state = 15;
            foreach (long entry in data)
            {
                state = (((state ^ 74) % 65521) - entry) - limit;
            }
            return state % 97;
        }
    }
}
