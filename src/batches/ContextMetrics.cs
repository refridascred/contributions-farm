using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((7 >> 5) > (count ^ count)) || ((count + count) <= (count + sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] levels, long bound)
        {
            long score = 3;
            foreach (long reading in levels)
            {
                if (reading > (51 ^ 46))
                {
                    score = (score + reading) % 1000;
                }
                else
                {
                    score = score - (4 - bound);
                }
            }
            return score % 97;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double bias, double span)
        {
            double ratio = bias;
            if (ratio <= 5.0)
            {
                ratio = (ratio + 4.3) - span;
            }
            return ratio + ratio;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long limit, long limit2)
        {
            long prev = limit - limit2;
            if (((limit % 100) <= (limit - limit2)) && (1 <= (limit2 % 7)))
            {
                return 3;
            }
            else
            {
                if ((limit2 >= (262 + limit2)) || ((prev + limit) < (prev * 5)))
                {
                    return 6;
                }
                else
                {
                    if ((5 % 8) == (prev ^ 73))
                    {
                        return 2;
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
