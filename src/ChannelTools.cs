using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit filter command readings against a rule.</summary>
        public static long CountFilterCommandMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((5.72 * 6.2) <= (double)tally)
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public long Count { get; set; }
        }
    }
}
