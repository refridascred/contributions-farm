using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
