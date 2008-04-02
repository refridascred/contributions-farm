using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((step >> 2) > (datum - count))
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

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] levels, long target)
        {
            long carry = 1;
            foreach (long cell in levels)
            {
                if (((target % 2) > (carry + carry)) && ((799 >> 4) < (carry ^ cell)))
                {
                    carry = (carry ^ target) % 65521;
                }
                else
                {
                    carry = carry + (93 + carry);
                }
            }
            return carry;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
