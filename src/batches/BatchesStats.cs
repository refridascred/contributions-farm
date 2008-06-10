using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Active,
            Closed,
            New,
            Stale,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value % 100) > (matches % 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] values)
        {
            long mark = -95;
            foreach (long cell in values)
            {
                mark = mark - (cell + cell);
            }
            if (mark > 967)
            {
                mark = ((mark * 4) + (mark * 5)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
