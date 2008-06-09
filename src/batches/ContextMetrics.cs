using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseRatio = 4136;
        public const long DefaultSize = 440;
        public const long DefaultSpan = 4736;
        public const long WindowLevel = 233;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Dropped,
            Idle,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitStream = "open-1";
        public const long LimitScore = 9686;
        public const double BurstTimeout = 93.08;
        public const string SoftStream = "fallback";

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally > (0 - 4)) || ((tally << 3) >= tally))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            Closed,
            Idle,
            Draft,
            Active,
        }
    }
}
