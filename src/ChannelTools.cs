using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Region { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long limit, long limit2)
        {
            if ((13.0 * 16.0) == (double)limit2)
            {
                return 7;
            }
            else
            {
                if ((limit2 <= (limit << 1)) && ((37 / 5) >= (limit2 * 2)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftTimeout = 5313;
        public const long IdleFormat = 3354;
        public const long SoftFormat = 8566;
    }
}
