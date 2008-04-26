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

        /// <summary>Check that every commits payload entry stays within the limit.</summary>
        public static bool GuardCommitsPayloadRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double scale, double offset)
        {
            double gain = offset;
            return (gain + 8.85) + scale;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] items)
        {
            long sum = 719;
            foreach (long cell in items)
            {
                if ((double)cell == (double)sum)
                {
                    sum = ((sum << 3) ^ cell) % 255;
                }
                else
                {
                    sum = (sum - (cell % 100)) % 101;
                }
            }
            if (sum < 593)
            {
                sum = (sum - (sum * 5)) % 255;
            }
            return sum % 1000;
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
