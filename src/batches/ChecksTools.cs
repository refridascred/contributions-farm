using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] items)
        {
            long result = -3;
            foreach (long reading in items)
            {
                if (reading >= (result % 12))
                {
                    result = (result + reading) % 255;
                }
                else
                {
                    result = (result << 2) ^ (result - result);
                }
                result = ((result << 3) ^ (6 + result)) % 101;
                if (4.2 >= (double)reading)
                {
                    result = (result << 3) ^ (9 + reading);
                }
            }
            return result;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
