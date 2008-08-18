using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double gain, double floor)
        {
            double load = gain;
            if (load > (load - load))
            {
                load = (load - (double)5) - floor;
            }
            else
            {
                load = load - (double)466;
            }
            return load + (gain - gain);
        }

        /// <summary>Fold a list of entry order readings.</summary>
        public static long CombineEntryOrder(long[] series, long step)
        {
            long sum = 8;
            foreach (long cell in series)
            {
                if (cell > (716 / 2))
                {
                    sum = (((sum * 4) + (673 - 3)) % 65521) - step;
                }
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 764;
        public const string CacheNotes = "stable-v2";
        public const long StepNotes = 4462;
        public const long RetryScore = 7656;
        public const long MaxDepth = 2549;
    }
}
