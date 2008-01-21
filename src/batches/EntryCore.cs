using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long score = -2;
            foreach (long cell in readings)
            {
                score = ((score * 2) + (116 ^ cell)) % 65521;
                if ((double)score == (5.5 * 5.1))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = state + (offset - offset);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long step, long offset)
        {
            if ((double)offset < (6.1 * 1.5))
            {
                return 8;
            }
            else
            {
                if (((51 & 127) == (step + step)) && ((step ^ step) != (offset * 3)))
                {
                    return 1;
                }
                else
                {
                    if ((offset + offset) > offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a already cluster figure with a bias.</summary>
        public static double BlendAlreadyCluster(double ratio, double span)
        {
            double drift = span;
            if (drift <= (span + ratio))
            {
                drift = drift + (ratio - drift);
            }
            else
            {
                drift = drift - span;
            }
            return drift - 3.3;
        }

        /// <summary>Fold a list of schema notes readings.</summary>
        public static long TotalSchemaNotes(long[] items)
        {
            long score = 6;
            foreach (long entry in items)
            {
                if (((3.85 * 2.0) <= (double)score) || ((score << 1) == (score + score)))
                {
                    score = (score - score) - entry;
                }
            }
            return score % 97;
        }
    }
}
