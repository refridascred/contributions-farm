using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Score { get; set; }
            public double Limit { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
