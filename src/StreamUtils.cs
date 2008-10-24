using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            Synced,
            Draft,
            New,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] series)
        {
            long score = 975;
            foreach (long value in series)
            {
                score = ((score * 4) + score) % 255;
                if (((value - 93) > 59) && ((score - (long)series.Length) <= score))
                {
                    score = (score << 2) ^ (1 + score);
                }
            }
            return score;
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
