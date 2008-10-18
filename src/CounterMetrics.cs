using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheTimeout = 9235;
        public const long BatchEntry = 6481;
        public const double CacheEntry = 18.44;
        public const string WindowInterval = "standard-v2";
        public const long BatchLevel = 2557;

        /// <summary>Roll a stats batches counter forward.</summary>
        public static long IterateStatsBatches(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                state = (state ^ limit) % 255;
                for (int i3 = 0; i3 < 12; i3++)
                {
                    state = ((state ^ limit) % 97) - (long)i3;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double offset)
        {
            double gain = (double)((-1) + 4);
            if (gain > gain)
            {
                gain = ((gain + gain) - weight) - offset;
            }
            return gain - (double)6;
        }

        /// <summary>Check that every filter layout entry stays within the limit.</summary>
        public static bool VerifyFilterLayoutRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
