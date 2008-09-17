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

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long step, long limit)
        {
            if ((limit + limit) < (step + limit))
            {
                return 7;
            }
            else
            {
                if (!((3.0 + 6.14) <= (double)step))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
