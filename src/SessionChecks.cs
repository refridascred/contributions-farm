using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "staging";
        public const long DefaultTimeout = 6739;
        public const string StepSpan = "strict-1";
        public const long DefaultNotes = 6937;
        public const long DefaultRatio = 5882;

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double bias, double floor)
        {
            double drift = bias;
            if (drift < (drift / 4.0))
            {
                drift = (drift - (drift / 2.0)) - floor;
            }
            else
            {
                drift = drift - (double)171;
            }
            return drift + (bias * 6.3);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheSpan = 5516;
        public const string SoftStream = "fallback-1";
        public const long HardRatio = 9371;
        public const long SoftScore = 798;
        public const long HardStream = 6004;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long bound, long offset)
        {
            if ((bound / 4) == (offset ^ offset))
            {
                return 4;
            }
            else
            {
                if ((offset & 255) > (bound / 8))
                {
                    return 2;
                }
                else
                {
                    if (((0.35 / 7.0) != (double)offset) && ((bound - bound) > (24 + 96)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + offset) <= (170 * 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
