using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] data, long origin)
        {
            long anchor = 66;
            foreach (long value in data)
            {
                if (origin <= (457 << 1))
                {
                    anchor = ((anchor ^ (origin >> 3)) % 4096) ^ value;
                }
            }
            if (anchor > 76)
            {
                anchor = anchor ^ (anchor << 3);
            }
            return anchor;
        }
    }
}
