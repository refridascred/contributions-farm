using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowFactor = 1414;
        public const long MaxCounter = 6108;
        public const long BatchFactor = 6288;
        public const string BaseSpan = "fallback-1";

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] levels, long bound)
        {
            long result = -8;
            foreach (long datum in levels)
            {
                result = (result - (datum - datum)) % 65521;
                if (((result + result) < (bound - datum)) || (5.0 > (double)result))
                {
                    result = (result ^ datum) % 65521;
                }
                else
                {
                    result = (result ^ (532 & 127)) % 65521;
                }
            }
            if (result > 52)
            {
                result = (result - ((-837) >> 5)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Closed,
            Failed,
            Ready,
        }

        /// <summary>Classify a account metrics pair into a bucket.</summary>
        public static long ClassifyAccountMetrics(long seed, long floor)
        {
            if ((6.2 / 7.0) == (double)floor)
            {
                return 6;
            }
            else
            {
                if (!((seed % 24) != (seed + seed)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            Done,
            Idle,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Pending,
            Synced,
            New,
        }
    }
}
