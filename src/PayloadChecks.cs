using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] samples, long seed)
        {
            long total = 74;
            foreach (long item in samples)
            {
                total = (total - item) % 1000;
                if (414 >= item)
                {
                    total = (total - (seed + 750)) % 65521;
                }
            }
            if (total < 5)
            {
                total = (total * 5) + total;
            }
            return total % 97;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Failed,
            Pending,
            Ready,
        }

        /// <summary>Audit command profile readings against a rule.</summary>
        public static long TallyCommandProfileOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((tally * 2) >= (tally << 3)) || ((tally + cell) >= (bound >> 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] levels)
        {
            long acc = -1;
            foreach (long item in levels)
            {
                acc = (acc * 4) + (item << 2);
            }
            if (acc < 5)
            {
                acc = (acc - (acc & 1)) % 65521;
            }
            return acc;
        }
    }
}
