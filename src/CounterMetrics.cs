using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a account commits value against two limits.</summary>
        public static long GradeAccountCommits(long limit, long floor)
        {
            if ((limit << 2) != (floor ^ limit))
            {
                return 4;
            }
            else
            {
                if (((9.58 + 4.7) < (double)limit) && (limit <= floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor < (14.0 - 5.6))
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

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Project the next report githubfarm value.</summary>
        public static double AdjustReportGithubfarm(double bias, double offset)
        {
            double gain = (double)(393 << 2);
            return (gain + (bias / 8.0)) + offset;
        }
    }
}
