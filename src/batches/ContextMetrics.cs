using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] values, long floor)
        {
            long total = -14;
            foreach (long cell in values)
            {
                if (!((total % 2) < (cell + cell)))
                {
                    total = (total ^ ((-59) ^ total)) % 1000;
                }
                if (((total - total) >= (cell * 4)) && ((13.0 + 12.0) != (double)floor))
                {
                    total = (total ^ total) % 97;
                }
            }
            return total;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Ratio { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many githubfarm metrics samples are out of range.</summary>
        public static long CountGithubfarmMetricsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (tally < (datum % 8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public long Size { get; set; }
        }
    }
}
