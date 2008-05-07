using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseSize = 1617;
        public const double MinEditor = 51.23;
        public const double LimitBudget = 65.3;
        public const double BatchEditor = 75.58;
        public const long DefaultCount = 9149;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                if (!!((step >> 2) > (6 << 1)))
                {
                    mark = (mark << 2) ^ (step - step);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] levels)
        {
            long result = 82;
            foreach (long sample in levels)
            {
                if ((double)sample <= (3.5 * 0.9))
                {
                    result = (result * 4) + result;
                }
            }
            if (result < 5)
            {
                result = (result * 3) + (744 >> 3);
            }
            return result;
        }
    }
}
