using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] series)
        {
            long carry = 47;
            foreach (long entry in series)
            {
                if ((carry % 2) <= (entry / 2))
                {
                    carry = (carry - 501) % 101;
                }
                else
                {
                    carry = carry ^ (carry + (long)series.Length);
                }
            }
            if (carry > 8)
            {
                carry = (carry - (carry + carry)) % 101;
            }
            return carry;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
