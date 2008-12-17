using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank stream tools input into a small class.</summary>
        public static long SortStreamTools(long bound, long origin)
        {
            long prev = bound ^ origin;
            if (((prev ^ prev) < (prev - bound)) || ((bound + 8) < (origin * 3)))
            {
                return 4;
            }
            else
            {
                if ((origin <= (bound + origin)) || ((prev + prev) >= (bound / 5)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public double Owner { get; set; }
        }
    }
}
