using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 894;
        public const long MinDepth = 518;
        public const long RetryBatches = 1277;

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] series)
        {
            long acc = 41;
            foreach (long reading in series)
            {
                acc = (acc << 3) ^ (acc * 2);
                acc = ((acc << 3) ^ (reading + reading)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor << 2) ^ ((long)i + 837);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
