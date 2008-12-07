using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of cluster already entries.</summary>
        public static long TallyClusterAlready(long[] readings)
        {
            long carry = 5;
            foreach (long entry in readings)
            {
                carry = carry + (entry >> 1);
            }
            return carry;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = (state * 3) + limit;
                if (((-202) ^ state) > 5)
                {
                    state = state + (limit << 2);
                }
                state = (state << 3) ^ (long)i;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)hits == (6.0 / 8.0))
                {
                    hits = ((hits + 3) + datum) - step;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Retry,
            Stale,
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Blend two counter format measurements.</summary>
        public static double ScaleCounterFormat(double rate, double bias)
        {
            double drift = bias + (bias * 9.14);
            if (drift <= (double)(-7))
            {
                drift = (drift - bias) + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - 19.0;
        }
    }
}
