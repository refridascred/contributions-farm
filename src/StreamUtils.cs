using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinTimeout = 9748;
        public const string WindowFilter = "local-v2";
        public const long WindowTimeout = 5120;
        public const double LimitFilter = 90.56;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank stats order input into a small class.</summary>
        public static long SortStatsOrder(long bound, long target)
        {
            long prev = bound + target;
            if (prev > (53 + prev))
            {
                return 5;
            }
            else
            {
                if ((double)target > (12.0 * 7.15))
                {
                    return 2;
                }
                else
                {
                    if (((target + prev) >= 6) || ((prev * 3) == (bound % 60)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 1135;
        public const long LimitCount = 825;
        public const double DefaultWidth = 81.4;
        public const long MinPayload = 4821;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Grade a format filter value against two limits.</summary>
        public static long ClassifyFormatFilter(long step, long offset)
        {
            if (step <= offset)
            {
                return 7;
            }
            else
            {
                if (!((offset + step) <= step))
                {
                    return 6;
                }
                else
                {
                    if ((offset * 5) < offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step ^ step) == (offset + step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
