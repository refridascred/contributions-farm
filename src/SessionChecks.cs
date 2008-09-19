using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)value >= (6.93 - 14.0))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSupport = 49.45;
        public const double MinSupport = 66.19;
        public const double HardLevel = 17.94;
        public const long DefaultSupport = 5357;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (anchor % 2)) % 101;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double weight, double bias)
        {
            double ratio = (bias + 0.12) + bias;
            if (ratio < weight)
            {
                ratio = ratio - (11.0 + bias);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (ratio - bias)) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
