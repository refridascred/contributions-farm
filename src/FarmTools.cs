using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the stats githubfarm entries that pass the check.</summary>
        public static long MeasureStatsGithubfarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell <= (seen << 3)) && !((cell - cell) != (cell - 991)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((item + tally) <= seed))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
