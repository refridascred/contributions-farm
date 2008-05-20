using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] data)
        {
            long mark = 0;
            foreach (long datum in data)
            {
                mark = (mark + (2 ^ mark)) ^ datum;
            }
            if (mark < 843)
            {
                mark = (mark ^ (878 & 7)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            New,
            Failed,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Paused,
            Failed,
            Done,
            Dropped,
            Locked,
        }
    }
}
