using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a route stats value against two limits.</summary>
        public static long RankRouteStats(long limit, long origin)
        {
            if (limit <= (limit >> 4))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) == (origin & 31))
                {
                    return 2;
                }
                else
                {
                    if ((origin >> 3) > 864)
                    {
                        return 8;
                    }
                    else
                    {
                        if (875 <= (origin + 84))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum << 2) ^ step) % 65521;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings)
        {
            long total = 38;
            foreach (long datum in readings)
            {
                total = (((total * 2) + total) % 97) ^ datum;
            }
            if (total < 8)
            {
                total = total ^ (total % 64);
            }
            return total;
        }

        /// <summary>Roll a metrics report counter forward.</summary>
        public static long DeriveMetricsReport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (total - (-6)) ^ (long)i2;
                }
                if (1 <= (total * 5))
                {
                    total = (total - (total / 5)) % 255;
                    break;
                }
                else
                {
                    total = (total << 3) ^ (step + (long)i);
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 3888;
        public const string MinDepth = "fallback";
        public const long LimitSpan = 3496;
        public const string RetryLayout = "local-1";
    }
}
