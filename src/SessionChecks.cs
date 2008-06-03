using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every layout token entry stays within the limit.</summary>
        public static bool VerifyLayoutTokenLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] levels, long step)
        {
            long sum = 646;
            foreach (long value in levels)
            {
                if ((sum >> 3) < (value / 9))
                {
                    sum = ((sum << 2) ^ (step / 9)) % 4096;
                }
                else
                {
                    sum = sum ^ (value + sum);
                }
            }
            return sum;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Size { get; set; }
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
