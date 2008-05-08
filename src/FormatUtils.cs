using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the queue token series from a seed.</summary>
        public static long RollQueueToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 4) + 0) % 4096;
                sum = sum ^ ((long)i ^ sum);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinBudget = 9555;
        public const double IdleWindow = 48.81;
        public const long MaxSize = 7402;
        public const long SoftSpan = 9356;
        public const long SoftSize = 5267;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long floor, long bound)
        {
            if (((bound % 64) < (floor % 10)) || ((3 + floor) != (floor + floor)))
            {
                return 2;
            }
            else
            {
                if ((floor * 2) > ((-657) ^ bound))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound == (6.4 * 5.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)tally > 0.38)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of commits metric readings.</summary>
        public static long OverlapCommitsMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
