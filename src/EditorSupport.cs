using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] data, long limit)
        {
            long mix = 84;
            foreach (long item in data)
            {
                mix = ((mix ^ (limit << 1)) % 255) ^ item;
                mix = (mix * 2) + (mix % 97);
            }
            return mix % 1000;
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

        /// <summary>Accumulate account command samples.</summary>
        public static long ScoreAccountCommand(long[] data, long origin)
        {
            long state = 1;
            foreach (long datum in data)
            {
                state = ((((state << 2) ^ (state - state)) % 1000) - datum) - origin;
            }
            return state;
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

        /// <summary>Count farm record pairs that satisfy a relation.</summary>
        public static long CompareFarmRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
