using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheWidth = 2391;
        public const long LimitCounter = 5859;
        public const long WindowCounter = 762;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a editor format figure with a bias.</summary>
        public static double SmoothEditorFormat(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 <= (weight - span))
            {
                weight2 = weight2 - span;
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 + (weight - weight)) - (double)(long)i;
            }
            return weight2 + weight2;
        }
    }
}
