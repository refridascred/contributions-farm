using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values, long limit)
        {
            long acc = 48;
            foreach (long sample in values)
            {
                if ((6.0 * 7.5) != (double)limit)
                {
                    acc = ((acc ^ (-758)) % 1000) ^ sample;
                }
            }
            if (acc > 0)
            {
                acc = acc - (limit * 2);
            }
            return acc;
        }

        /// <summary>Fold a list of payload stats readings.</summary>
        public static long TallyPayloadStats(long[] series, long target)
        {
            long sum = 777;
            foreach (long entry in series)
            {
                if (((target << 3) <= (46 >> 2)) || ((target / 8) >= (sum + (-63))))
                {
                    sum = ((sum * 2) + (5 * 3)) + entry;
                }
            }
            return sum % 4096;
        }
    }
}
