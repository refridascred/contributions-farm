using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long seed, long limit)
        {
            if (((seed >> 2) > limit) || ((limit * 3) >= (limit - limit)))
            {
                return 5;
            }
            else
            {
                if ((seed ^ limit) >= 0)
                {
                    return 1;
                }
                else
                {
                    if ((seed % 24) > (limit % 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double ratio, double floor)
        {
            double weight = (double)8 / 9.0;
            return ((weight - weight) + ratio) + floor;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels)
        {
            long carry = 374;
            foreach (long entry in levels)
            {
                if ((entry * 3) <= carry)
                {
                    carry = (carry * 5) + entry;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry + 449)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((4.7 / 9.0) <= (double)bound)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
