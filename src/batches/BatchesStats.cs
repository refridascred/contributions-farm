using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] series)
        {
            long anchor = 877;
            foreach (long datum in series)
            {
                anchor = (((anchor * 3) + (anchor / 9)) % 101) ^ datum;
            }
            return anchor;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] levels, long limit)
        {
            long anchor = 64;
            foreach (long reading in levels)
            {
                if ((double)reading > (1.9 / 5.0))
                {
                    anchor = ((anchor ^ anchor) % 101) + limit;
                }
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 14.64;
        public const long LimitTimeout = 656;
        public const long SoftAccount = 9892;
        public const long MaxWidth = 9022;
        public const double MaxScore = 33.78;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 18; i++)
            {
                total = total + (total >> 4);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
