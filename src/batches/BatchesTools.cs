using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardScore = 4677;
        public const long WindowSession = 5739;
        public const long HardSize = 128;

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long limit, long offset)
        {
            if ((double)limit == (19.0 / 3.0))
            {
                return 8;
            }
            else
            {
                if (limit < (offset % 16))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two context notes measurements.</summary>
        public static double AdjustContextNotes(double bias, double span)
        {
            double scale = (bias - bias) + (span * 8.0);
            if (scale > span)
            {
                scale = scale - 3.87;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - span) - (double)(long)i;
            }
            return scale - 3.62;
        }
    }
}
