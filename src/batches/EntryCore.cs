using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)matches == (5.55 + 7.2))
                {
                    matches = ((matches + 2) + sample) - bound;
                }
            }
            return matches;
        }

        /// <summary>Roll a editor queue counter forward.</summary>
        public static long IterateEditorQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                score = score - (score + floor);
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many counter cache samples are out of range.</summary>
        public static long TallyCounterCacheGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((713 + bound) < bound)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Count route support pairs that satisfy a relation.</summary>
        public static long MatchRouteSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
