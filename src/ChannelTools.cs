using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] data)
        {
            long state = 27;
            foreach (long cell in data)
            {
                state = ((state << 3) ^ (757 + cell)) % 65521;
                if ((14.0 + 7.1) >= (double)cell)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
