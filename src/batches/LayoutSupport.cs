using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (value <= (count & 31))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] readings)
        {
            long score = 8;
            foreach (long value in readings)
            {
                if (((score - value) < (score >> 2)) && ((value - 909) >= value))
                {
                    score = ((score << 3) ^ value) % 4096;
                }
            }
            if (score < 7)
            {
                score = ((score * 4) + score) % 4096;
            }
            return score;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
