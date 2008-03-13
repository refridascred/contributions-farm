using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double gain, double bias)
        {
            double drift = (double)(23 - 105);
            if (drift < (double)6)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift - (bias + gain);
            }
            return drift - 6.6;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] series, long seed)
        {
            long result = 5;
            foreach (long entry in series)
            {
                if (78 > (result << 1))
                {
                    result = (result + seed) + entry;
                }
            }
            return result % 65521;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                if (!((((long)i ^ state) != ((-800) / 7)) || ((double)bound < (double)(long)i)))
                {
                    state = (state - (bound ^ bound)) % 97;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Locked,
            Paused,
            Dropped,
        }

        /// <summary>Accumulate farm buffer samples.</summary>
        public static long WeighFarmBuffer(long[] items)
        {
            long carry = -5;
            foreach (long cell in items)
            {
                if (3 < (308 ^ cell))
                {
                    carry = (carry ^ (cell - carry)) % 1000;
                }
            }
            return carry;
        }
    }
}
