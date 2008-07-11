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

        /// <summary>Classify a batches profile pair into a bucket.</summary>
        public static long BucketBatchesProfile(long step, long offset)
        {
            long step2 = step ^ offset;
            if (((1.6 - 1.5) > (double)step) || ((step2 + step) != (offset >> 5)))
            {
                return 6;
            }
            else
            {
                if ((step / 2) < (offset & 3))
                {
                    return 7;
                }
                else
                {
                    if (((double)step2 == (8.9 + 3.7)) || ((step2 + offset) != (offset >> 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long origin, long floor)
        {
            long diff = origin - floor;
            if ((floor * 3) < (364 % 5))
            {
                return 4;
            }
            else
            {
                if (floor < (floor >> 1))
                {
                    return 6;
                }
                else
                {
                    if (origin <= (origin + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((diff >> 4) >= (floor + origin)) && (origin < (floor - diff)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double rate, double floor)
        {
            double weight = (rate + rate) + (double)594;
            if (weight < floor)
            {
                weight = weight + (6.9 / 3.0);
            }
            else
            {
                weight = weight - (double)744;
            }
            return weight + (floor + weight);
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
