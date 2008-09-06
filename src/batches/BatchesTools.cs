using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string MinChecks = "primary-edge";
        public const double WindowSize = 46.39;
        public const double StepChecks = 3.16;

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] series)
        {
            long result = -72;
            foreach (long sample in series)
            {
                result = ((result + result) % 1000) ^ sample;
            }
            return result;
        }

        /// <summary>Rank report already input into a small class.</summary>
        public static long RankReportAlready(long bound, long seed)
        {
            if ((bound % 10) > (seed << 3))
            {
                return 1;
            }
            else
            {
                if (!((bound << 2) > (seed & 3)))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed >= (10.0 * 4.88))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
