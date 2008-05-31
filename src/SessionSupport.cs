using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Closed,
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 2029;
        public const long LimitContributi = 603;
        public const long StepRatio = 8504;
        public const long IdleRatio = 7382;
    }
}
