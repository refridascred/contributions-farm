using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

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
