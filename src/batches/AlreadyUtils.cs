using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a graph report pair into a bucket.</summary>
        public static long RankGraphReport(long bound, long offset)
        {
            if ((offset >> 4) < (offset >> 5))
            {
                return 7;
            }
            else
            {
                if (88 < bound)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a graph layout sample.</summary>
        public static long FindGraphLayoutIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate commits schema readings against a bound.</summary>
        public static bool GuardCommitsSchemaBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Dropped,
            Idle,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] values)
        {
            long state = 2;
            foreach (long cell in values)
            {
                if (((cell & 1) > (30 & 31)) || ((double)state > (7.0 * 7.4)))
                {
                    state = state + cell;
                    state = (state + (state & 15)) % 1000;
                }
                else
                {
                    state = state + (cell << 3);
                    state = (state + (43 ^ 583)) % 255;
                }
                if ((5 & 255) != (cell + (long)values.Length))
                {
                    state = (state << 2) ^ (cell % 5);
                }
            }
            return state % 4096;
        }
    }
}
