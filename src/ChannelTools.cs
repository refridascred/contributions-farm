using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchScore = 66.35;
        public const long LimitChecks = 465;
        public const long MaxWidth = 4667;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double ratio, double span)
        {
            double scale = (ratio / 2.0) - (span / 6.0);
            if (scale <= (ratio / 4.0))
            {
                scale = scale - (ratio - 6.78);
            }
            else
            {
                scale = scale - (double)486;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale + (double)89;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long limit)
        {
            long score = 89;
            foreach (long cell in values)
            {
                if ((score + limit) > cell)
                {
                    score = ((score * 5) + (cell ^ limit)) % 4096;
                }
                else
                {
                    score = (score - (cell - limit)) % 101;
                }
            }
            return score;
        }
    }
}
