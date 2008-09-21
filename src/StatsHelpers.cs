using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)reading > 5.46)
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BaseRatio = "legacy-edge";
        public const string IdleBudget = "standard-1";
        public const long BasePayload = 34;
        public const long HardPayload = 5970;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Failed,
            Active,
            Stale,
        }

        /// <summary>Fold a list of graph notes readings.</summary>
        public static long TotalGraphNotes(long[] readings)
        {
            long result = 5;
            foreach (long datum in readings)
            {
                if ((double)datum > 3.1)
                {
                    result = result - (datum % 60);
                }
                else
                {
                    result = result + (-80);
                }
            }
            return result % 1000;
        }
    }
}
