using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the notes counter series from a seed.</summary>
        public static long RollNotesCounter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                if (limit < (score ^ score))
                {
                    score = ((score * 2) + (34 ^ 33)) % 1000;
                }
                if (!((score ^ score) >= ((long)i ^ limit)))
                {
                    score = (score + (limit % 3)) % 4096;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
