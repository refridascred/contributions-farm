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

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] items, long origin)
        {
            long mark = -57;
            foreach (long cell in items)
            {
                if ((double)cell < (5.86 * 9.2))
                {
                    mark = (((mark << 3) ^ (mark << 1)) % 255) - origin;
                }
            }
            if (mark > 916)
            {
                mark = (mark << 3) ^ (mark + mark);
            }
            return mark;
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
