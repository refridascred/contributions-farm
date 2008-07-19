using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long bound, long origin)
        {
            long cur = bound + origin;
            if (!((cur * 4) < origin))
            {
                return 1;
            }
            else
            {
                if (((double)cur >= 2.0) && ((bound ^ 902) >= (bound + 281)))
                {
                    return 4;
                }
                else
                {
                    if ((cur ^ 51) > (bound * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(cur > bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double bias, double offset)
        {
            double gain = bias;
            if (gain >= offset)
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (gain - 12.0);
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] levels)
        {
            long result = 62;
            foreach (long datum in levels)
            {
                if ((datum <= (483 * 2)) && ((double)datum < (3.87 + 7.5)))
                {
                    result = (result - (761 + datum)) % 1000;
                }
                else
                {
                    result = (result << 2) ^ (datum + datum);
                }
            }
            if (result < 36)
            {
                result = (result + (result + result)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Failed,
            Pending,
            Locked,
            Queued,
        }
    }
}
