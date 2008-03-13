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

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double weight, double offset)
        {
            double drift = 2.9;
            if (drift <= (weight + offset))
            {
                drift = drift - 9.2;
            }
            else
            {
                drift = drift + drift;
            }
            return drift + (double)8;
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

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double gain, double floor)
        {
            double weight = (floor + gain) / 8.0;
            if (weight > 9.2)
            {
                weight = weight - (floor * 9.7);
            }
            else
            {
                weight = weight + floor;
            }
            return weight - gain;
        }
    }
}
