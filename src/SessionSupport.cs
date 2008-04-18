using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)(long)items.Length >= (3.16 * 7.69))
                {
                    tally = ((tally + 1) + value) + step;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Ready,
            Locked,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }
    }
}
