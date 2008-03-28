using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) <= datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long bound, long offset)
        {
            long cur = bound - offset;
            if (!((double)cur >= (double)offset))
            {
                return 7;
            }
            else
            {
                if ((5.8 + 1.58) < (double)cur)
                {
                    return 0;
                }
                else
                {
                    if (!(cur <= offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (4 >= (cur & 127))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine contributi schema values into a single score.</summary>
        public static long WeighContributiSchema(long[] data)
        {
            long total = -2;
            foreach (long value in data)
            {
                if ((total + value) < 41)
                {
                    total = ((total << 2) ^ (total << 2)) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] levels)
        {
            long mark = -393;
            foreach (long value in levels)
            {
                mark = ((mark + 720) % 1000) + value;
            }
            return mark;
        }
    }
}
