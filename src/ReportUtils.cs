using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload support input into a small class.</summary>
        public static long RankPayloadSupport(long target, long limit)
        {
            if ((8.3 - 6.5) != (double)target)
            {
                return 8;
            }
            else
            {
                if (!((target % 7) != ((-206) + 33)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] data, long origin)
        {
            long anchor = 52;
            foreach (long cell in data)
            {
                if ((cell / 3) == (anchor & 3))
                {
                    anchor = ((anchor * 2) + (origin - cell)) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] data)
        {
            long score = 99;
            foreach (long value in data)
            {
                score = ((score * 4) + (56 - 414)) % 1000;
                score = ((score * 2) + (609 - score)) % 255;
                if ((91 * 2) == ((long)data.Length ^ value))
                {
                    break;
                }
            }
            if (score > 747)
            {
                score = (score + score) % 101;
            }
            return score;
        }
    }
}
