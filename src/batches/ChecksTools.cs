using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally - datum) < (tally % 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long step, long limit)
        {
            long edge = step ^ limit;
            if (0.03 >= (double)edge)
            {
                return 2;
            }
            else
            {
                if ((double)step < 8.3)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample >= (hits << 1))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
