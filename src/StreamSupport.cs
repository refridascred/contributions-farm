using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) != (tally + 4))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Score { get; set; }
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public string Score { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
