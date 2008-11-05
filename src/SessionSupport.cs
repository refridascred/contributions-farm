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

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Flag { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
