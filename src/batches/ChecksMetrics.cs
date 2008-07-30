using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
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

        /// <summary>Match up support context samples.</summary>
        public static long PairSupportContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
