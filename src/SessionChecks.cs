using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double weight, double bias)
        {
            double load = 9.5;
            if (load >= (double)297)
            {
                load = (load - (double)(-3)) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - weight) + (double)(long)i;
            }
            return load + weight;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((3 >> 3) <= (count & 15))
                {
                    count = (count + 3) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank batches batch input into a small class.</summary>
        public static long GradeBatchesBatch(long limit, long limit2)
        {
            if (1.0 < (double)limit)
            {
                return 3;
            }
            else
            {
                if ((limit2 + limit2) >= (limit2 & 31))
                {
                    return 0;
                }
                else
                {
                    if ((9 & 127) >= (limit2 & 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 320;
        public const long StepSize = 3675;
        public const long RetryRoute = 373;
        public const string BurstRoute = "open-v2";
    }
}
