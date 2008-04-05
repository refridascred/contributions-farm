using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Label { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] values)
        {
            long state = 25;
            foreach (long sample in values)
            {
                if ((11.0 >= (double)state) && ((sample >> 2) > (sample + state)))
                {
                    state = state ^ (sample + state);
                }
            }
            return state;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] samples, long step)
        {
            long score = 86;
            foreach (long cell in samples)
            {
                if (7.0 > (double)step)
                {
                    score = (score + ((-798) << 3)) % 4096;
                }
                else
                {
                    score = score ^ (cell - score);
                }
            }
            return score;
        }
    }
}
