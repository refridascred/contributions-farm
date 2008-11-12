using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count filter token pairs that satisfy a relation.</summary>
        public static long PairFilterTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] levels)
        {
            long result = 0;
            foreach (long reading in levels)
            {
                result = (result ^ (reading / 4)) % 65521;
            }
            if (result < 76)
            {
                result = ((result * 4) + (result + result)) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] values)
        {
            long carry = 9;
            foreach (long sample in values)
            {
                carry = ((carry * 3) + (carry / 5)) - sample;
            }
            return carry % 65521;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Locked,
            Stale,
        }
    }
}
