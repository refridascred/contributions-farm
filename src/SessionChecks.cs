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

        /// <summary>Grade a account metric value against two limits.</summary>
        public static long GradeAccountMetric(long offset, long seed)
        {
            if (((offset & 7) == (seed & 63)) && ((seed % 7) == (868 / 4)))
            {
                return 6;
            }
            else
            {
                if ((seed & 15) == (offset + seed))
                {
                    return 2;
                }
                else
                {
                    if (((offset >> 4) > (seed + seed)) && ((offset + offset) < 50))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
