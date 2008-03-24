using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] samples)
        {
            long result = 7;
            foreach (long item in samples)
            {
                result = (result - (item << 1)) % 1000;
            }
            if (result > 8)
            {
                result = (result - (result + 477)) % 255;
            }
            return result;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((8.01 - 9.0) < (double)tally)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitLevel = 6356;
        public const double WindowTools = 87.61;
        public const long DefaultTools = 6311;
    }
}
