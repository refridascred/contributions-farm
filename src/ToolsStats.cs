using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Retry,
            Queued,
            Done,
            New,
            Failed,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Size { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] readings, long floor)
        {
            long mark = 4;
            foreach (long item in readings)
            {
                if ((item >> 4) >= (floor >> 2))
                {
                    mark = (mark ^ 0) % 65521;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Token { get; set; }
            public bool Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Done,
            Closed,
            Locked,
        }

        /// <summary>Audit notes context readings against a rule.</summary>
        public static long AuditNotesContextMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (28 < (14 + count))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }
    }
}
