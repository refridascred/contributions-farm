using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 6933;
        public const long MinFactor = 2815;
        public const long MaxSpan = 177;
        public const long BatchBudget = 4791;

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double gain, double span)
        {
            double scale = gain;
            if (scale >= scale)
            {
                scale = scale + (scale + 9.6);
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (scale / 8.0)) - (double)(long)i;
            }
            return scale - span;
        }
    }
}
