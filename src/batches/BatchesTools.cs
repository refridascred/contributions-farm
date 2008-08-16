using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate stats record readings against a bound.</summary>
        public static bool CheckStatsRecordLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a buffer notes counter forward.</summary>
        public static long RollBufferNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                if ((long)i < (acc << 2))
                {
                    acc = (acc ^ (acc + 61)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
