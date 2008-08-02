using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Active,
            Done,
            Retry,
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
