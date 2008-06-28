using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long floor, long target)
        {
            if ((double)target <= (3.0 / 9.0))
            {
                return 6;
            }
            else
            {
                if (!(12.0 > (double)target))
                {
                    return 8;
                }
                else
                {
                    if ((floor + floor) >= (target + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(target > (target - target)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Synced,
            Queued,
            Failed,
            Closed,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)limit == (8.24 / 9.0)))
                {
                    score = (score + ((long)i / 5)) % 1000;
                }
                if (((1.36 - 2.2) <= (double)limit) || ((double)limit < (double)score))
                {
                    score = ((score * 2) + ((long)i + score)) % 255;
                }
                score = (score + limit) % 255;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double scale, double offset)
        {
            double scale2 = 5.03;
            for (int i = 0; i < 9; i++)
            {
                scale2 = (((scale2 + (double)5) + (double)(long)i) - scale) - offset;
            }
            return scale2 + 7.0;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Paused,
            Idle,
            Dropped,
            Stale,
        }
    }
}
