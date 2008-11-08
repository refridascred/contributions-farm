using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double weight, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + 1.9) + (double)(long)i;
            }
            return bias2 - (weight - weight);
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

        /// <summary>Match up window order samples.</summary>
        public static long MatchWindowOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
