using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Stale,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Adjust a batch graph reading.</summary>
        public static double ScaleBatchGraph(double rate, double floor)
        {
            double rate2 = 6.0;
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + (rate2 + floor)) + (double)(long)i;
            }
            return rate2 + rate;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] levels)
        {
            long state = 56;
            foreach (long entry in levels)
            {
                if (entry <= (state - entry))
                {
                    state = (state << 3) ^ (state / 5);
                }
            }
            if (state < 969)
            {
                state = state ^ state;
            }
            return state;
        }
    }
}
