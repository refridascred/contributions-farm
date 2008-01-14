using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Idle,
            Ready,
            Closed,
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
