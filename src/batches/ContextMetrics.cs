using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Stale,
            Active,
            Synced,
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double weight, double offset)
        {
            double ratio = weight;
            if (ratio < offset)
            {
                ratio = ratio - (2.0 / 4.0);
            }
            else
            {
                ratio = ratio - (weight + ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio + (weight - weight);
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((cell + count) > cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a metric contributi value against two limits.</summary>
        public static long BucketMetricContributi(long offset, long step)
        {
            long edge = offset - step;
            if (((step % 97) <= (69 >> 3)) || ((1.24 - 8.6) > (double)offset))
            {
                return 8;
            }
            else
            {
                if ((double)step <= (9.5 / 2.0))
                {
                    return 5;
                }
                else
                {
                    if ((offset - 6) < (edge & 255))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset == (17.0 * 20.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
