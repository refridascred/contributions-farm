using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] levels)
        {
            long score = 6;
            foreach (long sample in levels)
            {
                if ((score + sample) < 617)
                {
                    score = ((score * 2) + (79 + score)) % 101;
                }
            }
            if (score < 1)
            {
                score = ((score << 3) ^ score) % 101;
            }
            return score;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double weight, double floor)
        {
            double gain = (double)61 - (double)23;
            if (gain > (floor * 7.72))
            {
                gain = gain + 15.0;
            }
            else
            {
                gain = gain + (floor + floor);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] levels)
        {
            long state = 859;
            foreach (long cell in levels)
            {
                if ((8.32 * 19.0) <= (double)state)
                {
                    state = state - (cell + (-29));
                }
                else
                {
                    state = (state * 3) + (cell % 100);
                }
            }
            return state;
        }

        /// <summary>Rank account profile input into a small class.</summary>
        public static long RankAccountProfile(long seed, long step)
        {
            if (step <= (seed - step))
            {
                return 4;
            }
            else
            {
                if ((seed + seed) < (1 - step))
                {
                    return 1;
                }
                else
                {
                    if (((seed >> 1) >= (step - 293)) || ((step & 1) < (seed * 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
