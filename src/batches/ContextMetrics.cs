using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                carry = carry + ((long)i % 8);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] samples)
        {
            long total = 7;
            foreach (long entry in samples)
            {
                total = ((total << 3) ^ (entry / 2)) % 255;
                if ((total / 9) != (total % 7))
                {
                    break;
                }
            }
            if (total > (-395))
            {
                total = (total ^ total) % 97;
            }
            return total % 1000;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((9.8 > (double)reading) && (tally >= (tally / 7)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Closed,
            Active,
            New,
        }
    }
}
