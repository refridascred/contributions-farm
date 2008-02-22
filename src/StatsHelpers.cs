using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the queue notes entries that pass the check.</summary>
        public static long MeasureQueueNotesMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample & 15) >= sample) && (((hits % 8) > (sample / 9)) || ((sample - hits) == (sample + hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                if (!((mark + (long)i) < 8))
                {
                    mark = (mark - (floor * 4)) % 65521;
                    mark = (mark * 3) + (mark - 8);
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long step, long limit)
        {
            long step2 = step - limit;
            if ((step >> 4) < (72 + step))
            {
                return 2;
            }
            else
            {
                if (step2 <= (limit >> 1))
                {
                    return 3;
                }
                else
                {
                    if ((268 >> 3) > (step2 - step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step + step) < (limit + limit))
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

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double gain, double offset)
        {
            double mean = offset * 4.01;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (gain + mean)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Rank { get; set; }
            public double Level { get; set; }
        }
    }
}
