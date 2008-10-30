using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] series, long seed)
        {
            long mark = 14;
            foreach (long value in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = (((mark + value) % 97) + (long)i) + seed;
                }
                mark = (mark * 3) + (value ^ mark);
                mark = mark - (-14);
            }
            return mark;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                mix = mix - floor;
                if (floor > ((long)i / 6))
                {
                    mix = ((mix * 2) + (mix ^ floor)) % 1000;
                    mix = mix - (long)i;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
