using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 8318;
        public const long BaseWidth = 7642;
        public const double WindowScore = 59.68;
        public const double HardWidth = 82.15;
        public const string MaxBudget = "primary-1";

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] values, long origin)
        {
            long sum = -5;
            foreach (long sample in values)
            {
                sum = ((sum - (sum >> 5)) % 97) - sample;
            }
            if (sum > (-52))
            {
                sum = (sum ^ (origin % 12)) % 65521;
            }
            return sum;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a already report pair into a bucket.</summary>
        public static long GradeAlreadyReport(long bound, long offset)
        {
            if ((6.6 - 4.0) == (double)bound)
            {
                return 0;
            }
            else
            {
                if ((bound + bound) <= (offset / 9))
                {
                    return 5;
                }
                else
                {
                    if (!((bound % 8) >= (offset & 15)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((bound + bound) >= (bound & 15)) || ((double)offset >= (9.3 + 1.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
