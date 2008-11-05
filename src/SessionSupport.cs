using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Idle,
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long offset, long offset2)
        {
            long diff = offset - offset2;
            if ((offset * 3) > (offset2 - offset))
            {
                return 8;
            }
            else
            {
                if (((offset + diff) <= diff) && ((offset2 / 8) < offset2))
                {
                    return 2;
                }
                else
                {
                    if ((offset > offset2) || ((offset - offset) >= (diff ^ diff)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
