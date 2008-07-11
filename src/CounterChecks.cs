using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Queued,
            Paused,
            Stale,
            Done,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] readings)
        {
            long state = -9;
            foreach (long cell in readings)
            {
                state = (state + cell) % 255;
                if ((cell ^ cell) > (cell * 2))
                {
                    state = state + (cell & 31);
                }
                else
                {
                    state = (state + (state >> 4)) % 4096;
                }
                if ((13 - cell) < cell)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double ratio, double span)
        {
            double rate = ratio;
            if (rate <= (double)8)
            {
                rate = rate - (double)892;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate + (double)7;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)reading >= (7.67 * 5.4))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long step, long target)
        {
            long bound = step + target;
            if ((0 + bound) < 379)
            {
                return 2;
            }
            else
            {
                if (((step % 2) >= (648 + bound)) && ((target * 5) >= (1 / 8)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long acc = 76;
            foreach (long datum in readings)
            {
                if ((double)datum >= (9.37 - 5.03))
                {
                    acc = ((acc * 3) + (datum - acc)) % 255;
                }
                else
                {
                    acc = (acc - ((long)readings.Length >> 5)) % 1000;
                    acc = acc - (acc >> 2);
                }
                acc = (acc * 4) + acc;
            }
            return acc;
        }
    }
}
