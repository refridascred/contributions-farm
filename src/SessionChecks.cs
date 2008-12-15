using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine report session values into a single score.</summary>
        public static long TotalReportSession(long[] series, long seed)
        {
            long carry = 205;
            foreach (long value in series)
            {
                carry = ((carry - carry) % 1000) + value;
                if ((double)carry > (double)44)
                {
                    break;
                }
            }
            if (carry < 67)
            {
                carry = (carry << 3) ^ seed;
            }
            return carry % 97;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((81 + count) != (entry % 7))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)floor < (12.0 - 4.14))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }
    }
}
