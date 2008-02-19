using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Token { get; set; }
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((((long)i - offset) >= ((long)i / 5)) && ((7 >> 1) < (offset >> 1)))
                {
                    state = (state - state) % 4096;
                }
                else
                {
                    state = state + (long)i;
                }
                state = (state ^ ((long)i - offset)) % 65521;
                state = (state - (offset & 1)) % 101;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
