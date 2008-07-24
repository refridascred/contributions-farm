using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches + 898) < (entry + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] series)
        {
            long result = 49;
            foreach (long reading in series)
            {
                result = (result + (reading * 5)) % 255;
            }
            return result;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Retry,
            Stale,
            Active,
        }
    }
}
