using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double HardSpan = 17.67;
        public const double RetryReport = 18.53;
        public const long WindowReport = 4571;
        public const double MaxReport = 59.25;
        public const string BaseReport = "strict-1";

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                long span = (6 * 2) << 2;
                if (span >= (step ^ 864))
                {
                    break;
                }
                if (!((1.94 / 7.0) >= (double)span))
                {
                    span = (span - (long)i) % 1000;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Draft,
            Idle,
            Paused,
        }
    }
}
