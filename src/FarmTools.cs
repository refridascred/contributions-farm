using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] items)
        {
            long carry = -693;
            foreach (long sample in items)
            {
                if ((double)carry == (4.44 - 0.51))
                {
                    break;
                }
                else
                {
                    carry = (carry + (sample % 12)) % 65521;
                    carry = ((carry << 2) ^ (sample << 3)) % 65521;
                }
                if ((sample + carry) > (carry & 63))
                {
                    carry = ((carry << 2) ^ (carry + carry)) % 255;
                }
            }
            if (carry < 23)
            {
                carry = (carry + carry) % 1000;
            }
            return carry;
        }
    }
}
