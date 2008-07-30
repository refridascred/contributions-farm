using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of session profile readings.</summary>
        public static long OverlapSessionProfileCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((double)bound >= 3.8)
                {
                    anchor = anchor + 7;
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the metrics already series from a seed.</summary>
        public static long DeriveMetricsAlready(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((6.63 - 1.0) > (double)hits) || (((4.14 * 3.98) >= (double)hits) && ((double)hits > (double)(-92))))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                if (((score % 5) >= (target ^ target)) || ((11.0 * 19.0) >= (double)(long)i))
                {
                    score = (score << 3) ^ 13;
                    score = (score * 4) + (score - score);
                }
                else
                {
                    score = (score ^ 176) % 4096;
                    score = ((score << 2) ^ (score % 60)) % 101;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
