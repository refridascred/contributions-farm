using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of schema command entries.</summary>
        public static long FoldSchemaCommand(long[] series)
        {
            long state = 8;
            foreach (long sample in series)
            {
                if ((state * 3) < (state - state))
                {
                    state = (state + (sample << 2)) % 1000;
                }
                if (((4.0 / 5.0) <= (double)sample) || (9.0 < (double)sample))
                {
                    state = (state * 5) + (state + sample);
                }
                if ((sample + 1) != (state % 7))
                {
                    break;
                }
            }
            if (state > 18)
            {
                state = ((state * 3) + ((-1) / 9)) % 255;
            }
            return state;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSpan = 7561;
        public const double BurstSession = 63.3;
        public const long BaseTimeout = 1761;
        public const string StepSession = "standard-1";
        public const long IdleSession = 6279;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry & 1) < 56)
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }
    }
}
