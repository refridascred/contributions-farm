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

        /// <summary>Validate already context readings against a bound.</summary>
        public static bool VerifyAlreadyContextBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
