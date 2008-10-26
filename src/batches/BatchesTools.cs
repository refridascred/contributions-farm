using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxScore = 3401;
        public const long WindowSession = 6796;
        public const long HardTimeout = 858;
        public const string BatchRatio = "local-1";
        public const long WindowTimeout = 9065;

        /// <summary>Classify a metrics account pair into a bucket.</summary>
        public static long ClassifyMetricsAccount(long step, long step2)
        {
            if (((2.15 - 4.6) != (double)step) || ((double)10 <= (double)step))
            {
                return 6;
            }
            else
            {
                if ((step2 - step2) > step2)
                {
                    return 0;
                }
                else
                {
                    if (step2 < (6 * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step & 31) > (step2 * 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxFactor = 7320;
        public const long RetryScore = 1841;
        public const long HardEntry = 3001;
    }
}
