using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((9 >> 5) <= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 10;
        public const double DefaultBudget = 20.89;
        public const long LimitRatio = 3692;
        public const long RetryRoute = 1392;
    }
}
