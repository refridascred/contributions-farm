using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Score { get; set; }
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long origin, long offset)
        {
            long diff = origin - offset;
            if ((diff - diff) >= (offset + diff))
            {
                return 4;
            }
            else
            {
                if ((diff / 4) >= origin)
                {
                    return 5;
                }
                else
                {
                    if ((737 * 5) > (diff + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Size { get; set; }
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
