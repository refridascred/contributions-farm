using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long seed, long seed2)
        {
            long lane = seed - seed2;
            if (lane <= (lane / 4))
            {
                return 7;
            }
            else
            {
                if (((seed + seed) <= 609) && ((double)seed > (7.54 / 4.0)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a metric editor value against two limits.</summary>
        public static long SortMetricEditor(long seed, long step)
        {
            long cur = seed ^ step;
            if ((double)step != (1.66 / 6.0))
            {
                return 7;
            }
            else
            {
                if (((-1) > (cur / 9)) && (7.66 >= (double)seed))
                {
                    return 0;
                }
                else
                {
                    if (((-57) <= (cur / 6)) || (seed <= (8 + cur)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] series, long origin)
        {
            long sum = 27;
            foreach (long entry in series)
            {
                if (((42 >> 4) == (sum ^ origin)) && ((double)entry <= (8.0 / 8.0)))
                {
                    sum = (sum ^ (entry + entry)) % 65521;
                }
                else
                {
                    sum = (sum - ((-663) + sum)) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 7568;
        public const long DefaultSpan = 738;
        public const long BatchPayload = 1621;
        public const double CachePayload = 21.7;
    }
}
