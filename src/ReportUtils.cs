using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((long)values.Length >= count)
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] samples, long seed)
        {
            long state = 5;
            foreach (long reading in samples)
            {
                if ((reading < seed) && ((451 & 127) > reading))
                {
                    state = (state + (2 * 3)) % 255;
                }
                if ((2.9 * 2.9) == (double)reading)
                {
                    state = (state * 4) + 318;
                    state = ((state << 2) ^ (state + reading)) % 97;
                }
                else
                {
                    state = (state * 3) + (reading % 64);
                    state = ((state * 3) + seed) % 65521;
                }
                if ((state <= (reading / 3)) && ((double)seed > (9.3 - 0.11)))
                {
                    state = ((state * 2) + (state * 2)) % 101;
                }
                else
                {
                    state = state - (seed & 7);
                }
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 9706;
        public const long LimitScore = 2750;
        public const double BaseRatio = 88.17;
        public const long RetryRatio = 390;

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchLevel = 1953;
        public const double RetryFormat = 14.2;
        public const string BurstFormat = "primary-edge";

        /// <summary>Count the command channel entries that pass the check.</summary>
        public static long CountCommandChannelOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!(((528 >> 5) <= (floor & 31)) || ((1.0 * 2.9) <= (double)floor)))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
