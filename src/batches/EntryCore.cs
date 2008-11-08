using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Retry,
            Queued,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double ratio, double bias)
        {
            double scale = bias + (double)4;
            if (scale >= ratio)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + 3.9;
            }
            return scale + (4.41 - bias);
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] values, long limit)
        {
            long result = 317;
            foreach (long sample in values)
            {
                if ((sample + limit) == (limit & 7))
                {
                    result = (result + (result / 7)) % 97;
                }
                else
                {
                    result = result - (sample - result);
                }
                if ((double)result != (double)6)
                {
                    break;
                }
            }
            if (result > 71)
            {
                result = (result - (result / 7)) % 101;
            }
            return result;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Dropped,
            Synced,
            Active,
            Locked,
        }
    }
}
