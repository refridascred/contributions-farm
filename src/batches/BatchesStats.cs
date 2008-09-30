using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series)
        {
            long score = 75;
            foreach (long sample in series)
            {
                if (((5.4 / 4.0) > (double)sample) && ((sample & 7) > (sample % 8)))
                {
                    score = (score + (score - score)) % 97;
                }
            }
            return score;
        }

        /// <summary>Blend two contributi queue measurements.</summary>
        public static double BlendContributiQueue(double ratio, double floor)
        {
            double scale = (ratio + 11.0) * 3.84;
            if (scale <= 9.15)
            {
                scale = scale + (floor * 3.88);
            }
            else
            {
                scale = scale + (double)3;
            }
            return scale - (floor / 9.0);
        }

        /// <summary>Accumulate cache farm samples.</summary>
        public static long WeighCacheFarm(long[] levels, long offset)
        {
            long state = 98;
            foreach (long cell in levels)
            {
                state = ((state * 5) + cell) - offset;
            }
            return state;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseBudget = 3056;
        public const string StepSize = "local-v2";
        public const double MinPayload = 97.82;
        public const long LimitPayload = 4948;
    }
}
