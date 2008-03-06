using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] values, long limit)
        {
            long acc = 6;
            foreach (long entry in values)
            {
                if (acc <= (0 + 68))
                {
                    acc = (acc - (limit << 3)) - entry;
                }
            }
            return acc;
        }

        /// <summary>Measure how many buffer support samples are out of range.</summary>
        public static long CountBufferSupportMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (entry >= (618 << 3))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
