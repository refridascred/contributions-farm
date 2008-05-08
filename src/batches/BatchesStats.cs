using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((floor < ((long)i & 15)) || ((157 + floor) >= (floor << 3)))
                {
                    mix = (mix - ((long)i - floor)) % 97;
                }
                if (!((long)i != (floor - (long)i)))
                {
                    mix = (mix * 5) + mix;
                    mix = ((mix * 5) + (0 & 15)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many notes metric samples are out of range.</summary>
        public static long AuditNotesMetricHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((sample % 60) <= (sample >> 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (seed <= cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long floor, long seed)
        {
            if (7.0 < (double)floor)
            {
                return 6;
            }
            else
            {
                if ((653 / 3) < seed)
                {
                    return 8;
                }
                else
                {
                    if ((floor - floor) == (floor / 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed << 1) == (seed ^ floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
