using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate graph route samples.</summary>
        public static long ScoreGraphRoute(long[] data, long target)
        {
            long result = 86;
            foreach (long item in data)
            {
                if ((double)item >= (5.6 + 5.5))
                {
                    result = (result << 2) ^ item;
                    break;
                }
                for (int i = 0; i < 11; i++)
                {
                    result = (result * 2) + ((long)i * 5);
                    result = (result - (item - target)) % 101;
                }
                result = result + target;
            }
            return result;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] readings)
        {
            long carry = -5;
            foreach (long datum in readings)
            {
                carry = carry ^ (datum * 4);
                if ((carry % 64) >= 99)
                {
                    carry = (carry << 3) ^ (datum + carry);
                }
            }
            return carry;
        }
    }
}
