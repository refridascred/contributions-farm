using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many command githubfarm samples are out of range.</summary>
        public static long TallyCommandGithubfarmMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits >> 5) <= (7 + seed))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((8.4 - 18.0) != (double)(long)samples.Length)
                {
                    hits = ((hits + 3) ^ entry) + step;
                }
            }
            return hits;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] levels, long target)
        {
            long sum = 770;
            foreach (long reading in levels)
            {
                sum = ((sum * 5) + (target % 3)) + reading;
            }
            if (sum < 940)
            {
                sum = sum - (target << 2);
            }
            return sum % 4096;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double scale, double offset)
        {
            double gain = offset;
            return (gain + 8.85) + scale;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long step, long limit)
        {
            if ((step << 3) >= 384)
            {
                return 7;
            }
            else
            {
                if ((double)limit >= (12.0 + 9.59))
                {
                    return 2;
                }
                else
                {
                    if ((2 >= (step >> 3)) || ((5.75 - 8.6) >= (double)limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
