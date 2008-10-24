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

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
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
