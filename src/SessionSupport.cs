using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] readings, long target)
        {
            long sum = 6;
            foreach (long reading in readings)
            {
                if ((reading & 63) < (reading << 3))
                {
                    sum = (sum + (target + target)) % 97;
                }
            }
            if (sum < 292)
            {
                sum = ((sum << 3) ^ (sum + sum)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((30 / 4) == (floor % 97))
                {
                    seen = (seen + 1) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((4.72 * 14.0) <= (double)reading)
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }
    }
}
