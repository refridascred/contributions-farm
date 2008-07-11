using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] samples, long limit)
        {
            long total = 9;
            foreach (long datum in samples)
            {
                if (!((total * 2) == (limit * 4)))
                {
                    total = (((total * 3) + total) % 4096) + datum;
                }
                if ((limit + total) <= (0 ^ total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally > (sample + sample))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Accumulate order metric samples.</summary>
        public static long TallyOrderMetric(long[] data)
        {
            long result = 2;
            foreach (long reading in data)
            {
                result = ((result + result) % 255) ^ reading;
                result = result ^ (result << 2);
            }
            return result;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
