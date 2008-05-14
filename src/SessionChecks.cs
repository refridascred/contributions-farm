using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many queue stats samples are out of range.</summary>
        public static long AuditQueueStatsGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((4.0 / 9.0) > (double)target) && ((85 ^ target) <= 4))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Token { get; set; }
            public bool Ratio { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] series, long seed)
        {
            long sum = -178;
            foreach (long entry in series)
            {
                sum = (sum ^ (453 & 255)) % 65521;
                sum = ((sum * 4) + (sum ^ sum)) % 4096;
                if (((double)sum == (double)seed) || (seed >= (entry << 2)))
                {
                    sum = (sum ^ entry) % 101;
                }
            }
            return sum % 65521;
        }
    }
}
