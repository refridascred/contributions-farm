using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] series, long bound)
        {
            long result = 262;
            foreach (long entry in series)
            {
                if ((result + bound) >= result)
                {
                    result = (result ^ (result - result)) - entry;
                }
                else
                {
                    result = (result * 2) + (bound * 2);
                }
            }
            if (result < 1)
            {
                result = (result + 262) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] data)
        {
            long sum = 810;
            foreach (long value in data)
            {
                sum = sum ^ (value + 56);
            }
            if (sum < 382)
            {
                sum = ((sum << 2) ^ (sum / 2)) % 97;
            }
            return sum;
        }
    }
}
