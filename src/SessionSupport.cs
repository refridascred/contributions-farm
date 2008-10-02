using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)limit >= (6.0 / 5.0))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Total { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i ^ 9) <= 996) || ((89 - limit) != ((long)i + carry)))
                {
                    carry = carry ^ ((long)i / 6);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
