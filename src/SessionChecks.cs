using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate metrics buffer readings against a bound.</summary>
        public static bool CheckMetricsBufferBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = result + (result / 7);
                if (((result >> 4) > limit) && ((double)limit < (9.34 - 4.97)))
                {
                    continue;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] data)
        {
            long total = 430;
            foreach (long reading in data)
            {
                total = (total - (total >> 5)) % 101;
                total = (total << 2) ^ (reading - reading);
                if ((double)reading <= (7.77 * 8.8))
                {
                    total = (total << 3) ^ total;
                }
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 7875;
        public const double BatchContext = 21.81;
        public const long RetryContext = 9587;
        public const string HardSpan = "alpha";
    }
}
