using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long bound, long limit)
        {
            long diff = bound ^ limit;
            if (!(909 < (limit ^ bound)))
            {
                return 5;
            }
            else
            {
                if ((diff + diff) < diff)
                {
                    return 0;
                }
                else
                {
                    if (!((0 % 10) > bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Done,
            Closed,
            Active,
            Stale,
        }
    }
}
