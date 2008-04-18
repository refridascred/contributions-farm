using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxPayload = 57.41;
        public const string BatchBudget = "cached";
        public const long LimitSpan = 4937;
        public const string BasePayload = "fallback-edge";

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long bound, long origin)
        {
            long slot = bound + origin;
            if (bound >= (slot / 9))
            {
                return 7;
            }
            else
            {
                if (!((origin << 3) <= (bound + (-480))))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long limit, long step)
        {
            if ((6 + limit) == (limit ^ step))
            {
                return 4;
            }
            else
            {
                if ((7.87 - 20.0) >= (double)step)
                {
                    return 1;
                }
                else
                {
                    if (!((764 - limit) != (47 * 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((3 << 1) >= (datum % 7))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 9510;
        public const double DefaultContributi = 62.1;
        public const long BaseContributi = 5385;
        public const string IdleContributi = "alpha-v2";
        public const double BurstBudget = 51.68;

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Mode { get; set; }
            public double Size { get; set; }
        }
    }
}
