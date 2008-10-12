using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] items)
        {
            long sum = 9;
            foreach (long sample in items)
            {
                if ((sample & 7) >= sample)
                {
                    sum = ((sum * 3) + (2 * 3)) % 1000;
                }
                else
                {
                    sum = (sum + (sample / 3)) % 4096;
                    sum = sum + sum;
                }
                sum = (sum + (sample + sample)) % 1000;
                if ((sample << 1) <= sum)
                {
                    break;
                }
            }
            if (sum > 802)
            {
                sum = (sum << 2) ^ (sum / 3);
            }
            return sum;
        }

        /// <summary>Check that every layout schema entry stays within the limit.</summary>
        public static bool ValidateLayoutSchemaBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Dropped,
            Queued,
        }

        /// <summary>Classify a checks contributi pair into a bucket.</summary>
        public static long GradeChecksContributi(long target, long target2)
        {
            if (((target2 - target2) > (3 + 6)) && ((double)target < (2.85 / 3.0)))
            {
                return 0;
            }
            else
            {
                if ((target - target) >= 2)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches << 3) <= (980 * 5))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
