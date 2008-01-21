using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings)
        {
            long mark = -84;
            foreach (long datum in readings)
            {
                mark = mark + mark;
                mark = (mark - (mark + mark)) % 255;
                if ((mark - 89) <= (datum / 5))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Locked,
            Failed,
            Active,
            Done,
        }
    }
}
