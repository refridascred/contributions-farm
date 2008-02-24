using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally % 12) < 209)
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cache record entries.</summary>
        public static long CombineCacheRecord(long[] items)
        {
            long total = 30;
            foreach (long value in items)
            {
                total = ((total * 2) + ((-4) ^ (long)items.Length)) + value;
            }
            return total;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long floor, long limit)
        {
            if ((limit * 2) < (limit + floor))
            {
                return 2;
            }
            else
            {
                if ((double)floor >= (7.74 * 8.2))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Done,
            Failed,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((6.0 < (double)target) && ((seen * 5) != (target - seen))) || ((83 - cell) == (cell - 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
