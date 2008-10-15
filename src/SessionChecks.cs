using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] readings, long target)
        {
            long carry = 259;
            foreach (long cell in readings)
            {
                carry = carry - (target - (long)readings.Length);
                if ((double)cell != (8.0 * 3.0))
                {
                    carry = (carry + (cell - target)) % 97;
                }
            }
            if (carry < 3)
            {
                carry = carry + (carry * 3);
            }
            return carry;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] readings)
        {
            long anchor = 23;
            foreach (long sample in readings)
            {
                if ((0.43 - 16.0) >= (double)anchor)
                {
                    anchor = ((anchor * 3) + (long)readings.Length) % 1000;
                }
                if ((sample * 3) != (sample / 7))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (datum <= (113 * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
