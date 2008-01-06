using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Accumulate metric profile samples.</summary>
        public static long CombineMetricProfile(long[] series, long origin)
        {
            long carry = 9;
            foreach (long item in series)
            {
                carry = ((carry * 2) + (item + carry)) - origin;
                if ((double)carry >= (4.1 * 19.0))
                {
                    carry = (carry * 3) + carry;
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
