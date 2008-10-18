using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] data)
        {
            long sum = 69;
            foreach (long entry in data)
            {
                if ((entry * 2) >= (sum / 2))
                {
                    sum = sum + (7 << 2);
                }
                else
                {
                    sum = (sum ^ (entry >> 5)) % 4096;
                }
                if (((922 ^ entry) <= (sum >> 2)) || (sum > (sum >> 4)))
                {
                    sum = sum ^ (sum + (-3));
                }
                else
                {
                    sum = (sum - (entry << 1)) % 101;
                }
            }
            if (sum < 4)
            {
                sum = sum + (sum % 5);
            }
            return sum;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitRatio = 4953;
        public const double IdleAccount = 37.94;
        public const double MinAccount = 90.85;
        public const long LimitSpan = 7928;

        /// <summary>Measure how many cluster channel samples are out of range.</summary>
        public static long CountClusterChannelOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (target > ((long)samples.Length << 2))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Idle,
            Closed,
        }

        /// <summary>Find the first metric metrics entry that matches the target.</summary>
        public static long SeekMetricMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
