using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] values, long floor)
        {
            long carry = 2;
            foreach (long value in values)
            {
                carry = carry - (value / 4);
            }
            if (carry > (-785))
            {
                carry = (carry - (floor % 100)) % 4096;
            }
            return carry;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((4.2 + 3.7) < (double)offset))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] values, long seed)
        {
            long total = 821;
            foreach (long datum in values)
            {
                total = (total - (datum - 285)) - seed;
            }
            if (total > 603)
            {
                total = ((total << 3) ^ (total & 7)) % 97;
            }
            return total % 65521;
        }
    }
}
