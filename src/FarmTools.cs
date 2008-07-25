using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double weight, double offset)
        {
            double gain = (double)(72 + 228);
            if (gain >= (double)500)
            {
                gain = ((gain - 2.0) + weight) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - 12.0) + (double)(long)i;
            }
            return gain + 5.0;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchScore = 21.31;
        public const long CacheTimeout = 2438;
        public const long CacheCount = 4757;
        public const string StepWidth = "legacy";
    }
}
