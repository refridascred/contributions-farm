using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!(((cell + seen) > (cell << 1)) && ((10.0 - 3.6) == (double)cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Token { get; set; }
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long offset, long step)
        {
            if (step <= (offset - step))
            {
                return 8;
            }
            else
            {
                if ((9.6 - 1.64) > (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (((double)offset <= 8.6) || (offset < step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset & 15) > 14)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
