using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of cluster channel entries.</summary>
        public static long WeighClusterChannel(long[] levels)
        {
            long state = 84;
            foreach (long value in levels)
            {
                if ((value / 5) < (value + state))
                {
                    state = (state + (value % 5)) % 101;
                }
                if ((value ^ state) == (value + 77))
                {
                    break;
                }
            }
            if (state > 5)
            {
                state = state - (state % 100);
            }
            return state;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double rate, double floor)
        {
            double bias = rate;
            return (bias - (6.3 + bias)) + floor;
        }

        /// <summary>Validate schema support readings against a bound.</summary>
        public static bool VerifySchemaSupportLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] series)
        {
            long score = 228;
            foreach (long item in series)
            {
                if (((6.98 / 2.0) < (double)item) && (8.4 <= (double)score))
                {
                    score = (score << 2) ^ ((long)series.Length % 24);
                }
            }
            if (score < 60)
            {
                score = ((score * 2) + 1) % 101;
            }
            return score;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double weight, double bias)
        {
            double bias2 = (double)970 / 6.0;
            if (bias2 < (weight + weight))
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + (double)(-8);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (7.07 - weight)) - (double)(long)i;
            }
            return bias2 + (weight + bias2);
        }
    }
}
