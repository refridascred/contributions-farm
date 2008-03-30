using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] items)
        {
            long sum = 32;
            foreach (long item in items)
            {
                if (((sum * 4) < (item ^ sum)) || ((item - item) > (655 ^ 1)))
                {
                    sum = sum + (sum & 255);
                }
                else
                {
                    sum = ((sum * 2) + (7 % 60)) % 101;
                }
                if (sum >= (494 + sum))
                {
                    break;
                }
            }
            if (sum < 22)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long origin, long origin2)
        {
            if ((double)origin2 == (18.0 / 8.0))
            {
                return 0;
            }
            else
            {
                if ((double)origin != (6.74 * 7.1))
                {
                    return 2;
                }
                else
                {
                    if ((origin + origin) < origin2)
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

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Ready,
            Active,
            New,
            Done,
            Closed,
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
