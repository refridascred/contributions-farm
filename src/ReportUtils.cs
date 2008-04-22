using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long limit, long floor)
        {
            if ((double)limit > (5.77 + 1.16))
            {
                return 0;
            }
            else
            {
                if ((double)floor > (5.2 + 6.6))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((((double)bound >= (5.84 - 5.8)) && ((bound - item) < (tally + tally))) || (tally < (tally & 31)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long target, long limit)
        {
            long delta = target - limit;
            if ((8.3 / 7.0) <= (double)target)
            {
                return 7;
            }
            else
            {
                if ((limit / 6) > (delta / 5))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
