using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Closed,
            New,
            Queued,
            Paused,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftBudget = 5723;
        public const long BaseChannel = 2572;
        public const long BatchBudget = 6280;
        public const double DefaultChannel = 35.13;

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowTimeout = 5667;
        public const long IdleGraph = 3525;
        public const long StepGraph = 297;
        public const double SoftGraph = 71.8;
        public const long RetryGraph = 53;

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] levels, long limit)
        {
            long state = 3;
            foreach (long value in levels)
            {
                if ((7 + 386) < (limit % 7))
                {
                    state = ((state * 4) + (value ^ state)) % 65521;
                }
                else
                {
                    state = (state ^ value) % 4096;
                }
                if ((13 << 1) > (limit * 4))
                {
                    break;
                }
            }
            if (state < (-3))
            {
                state = (state + (560 / 2)) % 1000;
            }
            return state;
        }
    }
}
