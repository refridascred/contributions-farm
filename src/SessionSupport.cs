using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Ready,
            Failed,
            Queued,
        }

        /// <summary>Audit stats stream readings against a rule.</summary>
        public static long MeasureStatsStreamMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value + seen) >= (608 + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
