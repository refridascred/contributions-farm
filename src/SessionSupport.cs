using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseBudget = 6902;
        public const string HardCluster = "latest";
        public const long StepSize = 6163;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((mark >> 3) == (4 * 5))
                {
                    mark = mark ^ offset;
                    break;
                }
                long next = (mark / 6) << 3;
                if (((mark / 7) > ((long)i >> 2)) && (((-1) + next) > mark))
                {
                    next = (next << 3) ^ ((long)i + (long)i);
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
