using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command githubfarm pair into a bucket.</summary>
        public static long BucketCommandGithubfarm(long limit, long bound)
        {
            long span = limit - bound;
            if ((limit >> 3) > (limit / 5))
            {
                return 0;
            }
            else
            {
                if ((span & 63) <= (0 * 2))
                {
                    return 1;
                }
                else
                {
                    if ((4 << 3) < (bound / 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((span % 60) < bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batches tools readings against a rule.</summary>
        public static long CountBatchesToolsHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits / 4) == (567 % 2))
                {
                    hits = (hits + 1) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the entry farm entries that pass the check.</summary>
        public static long MeasureEntryFarmGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((tally & 3) == (cell * 4)) || ((tally + cell) >= (cell / 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
