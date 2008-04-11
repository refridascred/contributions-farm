using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long step, long limit)
        {
            long gap = step - limit;
            if ((limit + gap) == (41 << 3))
            {
                return 5;
            }
            else
            {
                if (((double)gap == (9.0 + 15.0)) && ((11 - gap) < gap))
                {
                    return 0;
                }
                else
                {
                    if ((11.0 * 9.94) < (double)gap)
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

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double gain, double span)
        {
            double gain2 = (gain - span) + span;
            if (gain2 <= (gain - gain))
            {
                gain2 = gain2 + gain;
            }
            else
            {
                gain2 = gain2 - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - span) + (double)(long)i;
            }
            return gain2 - (gain - 3.0);
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] levels, long bound)
        {
            long total = 29;
            foreach (long value in levels)
            {
                total = (((total << 3) ^ (-96)) - value) - bound;
            }
            return total;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
