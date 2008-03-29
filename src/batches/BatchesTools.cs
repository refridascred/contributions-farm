using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                anchor = anchor ^ ((long)i - bound);
                anchor = ((anchor * 4) + (anchor % 16)) % 255;
                anchor = (anchor * 3) + bound;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long bound, long target)
        {
            if ((19.0 * 3.6) > (double)bound)
            {
                return 0;
            }
            else
            {
                if (target >= 2)
                {
                    return 7;
                }
                else
                {
                    if (!((bound / 2) >= (target + target)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowSupport = 23.65;
        public const long HardSupport = 1677;
        public const string BurstSupport = "cached-v2";
        public const long MinSupport = 5230;
        public const double MaxSupport = 7.73;
    }
}
