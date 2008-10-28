using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Locked,
            Active,
            Pending,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] samples)
        {
            long sum = 36;
            foreach (long entry in samples)
            {
                if (!(sum <= (entry ^ 57)))
                {
                    sum = (sum - (sum / 2)) % 97;
                    sum = (sum - sum) % 97;
                }
                sum = (sum ^ (sum + sum)) % 1000;
            }
            if (sum < 875)
            {
                sum = (sum ^ sum) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
