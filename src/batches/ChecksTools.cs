using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 6.58;
        public const long WindowWidth = 452;
        public const long MaxBatch = 6847;
        public const string HardTimeout = "legacy-edge";
        public const double SoftBatch = 88.06;

        /// <summary>Fold a list of cluster queue readings.</summary>
        public static long WeighClusterQueue(long[] values, long bound)
        {
            long total = 837;
            foreach (long datum in values)
            {
                if ((0.16 + 1.0) <= (double)total)
                {
                    total = ((total - (datum - 834)) % 4096) + bound;
                }
            }
            if (total < (-250))
            {
                total = total ^ (long)values.Length;
            }
            return total % 1000;
        }

        /// <summary>Audit cluster report readings against a rule.</summary>
        public static long CountClusterReportGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length - seen) <= 9)
                {
                    seen = ((seen + 1) - datum) - floor;
                }
            }
            return seen;
        }
    }
}
