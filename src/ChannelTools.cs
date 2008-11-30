using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] items)
        {
            long carry = 327;
            foreach (long cell in items)
            {
                if ((cell + (-3)) < (cell - cell))
                {
                    carry = carry - 6;
                }
                else
                {
                    carry = ((carry << 2) ^ (cell * 2)) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 3) + (total + seed)) % 4096;
                if (!((282 - seed) == (total ^ seed)))
                {
                    total = (total * 4) + (total ^ seed);
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }
    }
}
