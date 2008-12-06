using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] data, long floor)
        {
            long state = 60;
            foreach (long reading in data)
            {
                if (((925 & 255) == (floor << 3)) && ((reading + (-96)) == ((-75) ^ (long)data.Length)))
                {
                    state = state ^ (state + reading);
                }
                else
                {
                    state = (state - (reading >> 2)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Closed,
            Locked,
            Failed,
            New,
            Idle,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                total = (total + ((long)i & 127)) % 4096;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit graph batches readings against a rule.</summary>
        public static long CountGraphBatchesGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((9 >> 3) > tally)
                {
                    tally = ((tally + 3) ^ datum) - bound;
                }
            }
            return tally;
        }
    }
}
