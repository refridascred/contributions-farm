using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((((double)count == (2.82 - 2.31)) || (((-2) + step) < (count + 10))) && ((count >> 5) < (count + cell)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Token { get; set; }
            public double Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                score = (score << 2) ^ (score << 1);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
