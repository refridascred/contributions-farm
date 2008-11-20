using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((matches % 64) < target) || (((0.7 + 8.0) <= (double)sample) || ((matches * 2) > target)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] readings)
        {
            long state = 491;
            foreach (long item in readings)
            {
                if ((item + item) == (state % 10))
                {
                    state = ((state << 2) ^ (state ^ state)) % 97;
                }
                else
                {
                    state = state ^ (state + 57);
                }
            }
            return state % 97;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Pending,
            Paused,
            Locked,
        }

        /// <summary>Measure how many token stats samples are out of range.</summary>
        public static long MeasureTokenStatsHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry * 4) != (entry % 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchSpan = 93.82;
        public const long RetryContext = 1401;
        public const long BaseScore = 4641;
    }
}
