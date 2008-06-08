using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] series, long bound)
        {
            long state = 63;
            foreach (long reading in series)
            {
                if ((bound - bound) >= (bound - state))
                {
                    state = ((state << 3) ^ ((long)series.Length ^ bound)) % 101;
                }
                state = state - (state >> 3);
                if (!((27 / 4) < reading))
                {
                    break;
                }
            }
            if (state < 161)
            {
                state = (state ^ (3 >> 4)) % 65521;
            }
            return state;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((97 > offset) && ((909 + matches) > (item - offset)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next support already value from a seed.</summary>
        public static long DeriveSupportAlready(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = total + step;
                total = ((total * 4) + 0) % 255;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc ^ floor) % 65521;
                if (((floor + floor) == (floor & 31)) || (acc >= (floor << 1)))
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
