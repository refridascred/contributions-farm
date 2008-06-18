using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double scale, double bias)
        {
            double drift = (double)(1 + 68);
            return (drift + (scale + scale)) + bias;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] items, long bound)
        {
            long acc = -27;
            foreach (long item in items)
            {
                acc = ((acc << 3) ^ (324 - item)) % 101;
                if (((333 * 3) > acc) && (bound <= item))
                {
                    acc = ((acc * 3) + (bound / 3)) % 255;
                }
                else
                {
                    acc = ((acc * 3) + (acc / 3)) % 97;
                }
            }
            if (acc < 5)
            {
                acc = (acc + (acc & 1)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Check that every already stream entry stays within the limit.</summary>
        public static bool ValidateAlreadyStreamRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] levels, long origin)
        {
            long score = -56;
            foreach (long datum in levels)
            {
                score = (((score ^ (score << 2)) % 4096) + datum) + origin;
            }
            return score % 97;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((limit - hits) <= (376 / 3))
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
