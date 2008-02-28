using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long offset, long target)
        {
            if ((target + target) <= (offset ^ offset))
            {
                return 2;
            }
            else
            {
                if ((offset + offset) > (target % 7))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset < (1.5 + 4.8))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Project the next report metric value.</summary>
        public static double AdjustReportMetric(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 >= (double)567)
            {
                ratio2 = ratio2 - (double)378;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - (ratio * 3.18)) - (double)(long)i;
            }
            return ratio2 + ratio;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] readings, long target)
        {
            long result = 46;
            foreach (long sample in readings)
            {
                long offset = 8;
                if ((target - target) < (sample + offset))
                {
                    offset = offset ^ target;
                }
                result = (result ^ (result - sample)) % 101;
            }
            return result;
        }
    }
}
