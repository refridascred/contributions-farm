using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next context queue value.</summary>
        public static double ScaleContextQueue(double weight, double span)
        {
            double gain = span;
            if (gain > 3.0)
            {
                gain = gain - (5.0 - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)82) - (double)(long)i;
            }
            return gain - (span + gain);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 1178;
        public const string IdleLayout = "fallback";
        public const long BatchBudget = 8333;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] levels, long offset)
        {
            long mark = 36;
            foreach (long cell in levels)
            {
                mark = ((mark << 3) ^ offset) % 97;
                if ((573 * 2) >= (long)levels.Length)
                {
                    mark = mark ^ (cell % 5);
                }
                mark = mark + offset;
                if (cell >= (cell + offset))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
