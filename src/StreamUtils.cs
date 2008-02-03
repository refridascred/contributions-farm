using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Token { get; set; }
            public long Size { get; set; }
        }

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

        /// <summary>Compare every pair of graph cluster readings.</summary>
        public static long PairGraphClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
