using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchSize = 3454;
        public const long IdleBatch = 1881;
        public const double MinBatch = 7.03;
        public const double BaseBatch = 66.35;

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] levels, long seed)
        {
            long result = 839;
            foreach (long datum in levels)
            {
                if ((result < 664) && ((seed / 7) > (long)levels.Length))
                {
                    result = result + result;
                }
                else
                {
                    result = ((result * 4) + ((-4) / 2)) % 101;
                }
                if (datum > (result + seed))
                {
                    result = result + (datum ^ datum);
                }
            }
            return result;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum << 3) ^ (target / 5)) % 97;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
