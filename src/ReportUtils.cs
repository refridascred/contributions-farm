using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Ratio { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Validate editor support readings against a bound.</summary>
        public static bool ValidateEditorSupportRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
