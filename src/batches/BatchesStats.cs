using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] data, long seed)
        {
            long state = -1;
            foreach (long entry in data)
            {
                state = (state ^ (entry % 12)) - seed;
            }
            return state % 97;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] data, long seed)
        {
            long state = 21;
            foreach (long datum in data)
            {
                if (state >= (state + state))
                {
                    state = state + seed;
                }
                if ((seed + (-222)) < (398 ^ seed))
                {
                    state = (state + (2 + datum)) % 4096;
                }
                else
                {
                    state = (state ^ (state << 3)) % 101;
                }
                if (seed < 10)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
