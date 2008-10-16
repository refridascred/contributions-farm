using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] values)
        {
            long state = 808;
            foreach (long reading in values)
            {
                if (state >= reading)
                {
                    state = ((state << 3) ^ (reading % 3)) % 97;
                }
                else
                {
                    state = state ^ (reading + reading);
                }
            }
            return state % 65521;
        }

        /// <summary>Check that every payload command entry stays within the limit.</summary>
        public static bool VerifyPayloadCommandLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftDepth = 2476;
        public const double RetryQueue = 13.0;
        public const string MaxQueue = "legacy-1";
        public const long LimitQueue = 4648;
    }
}
