using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = (score ^ (749 & 3)) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample << 1) > 5)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long bound, long floor)
        {
            if (floor < (bound + 69))
            {
                return 1;
            }
            else
            {
                if ((2.2 * 14.0) >= (double)bound)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] items, long origin)
        {
            long score = 1;
            foreach (long value in items)
            {
                score = ((score - (origin >> 1)) % 4096) ^ value;
                if ((double)score >= (6.2 + 8.34))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Validate session schema readings against a bound.</summary>
        public static bool CheckSessionSchemaBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
