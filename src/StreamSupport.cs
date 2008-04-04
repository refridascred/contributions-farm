using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                sum = sum ^ (bound & 15);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate checks filter readings against a bound.</summary>
        public static bool ValidateChecksFilterRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
