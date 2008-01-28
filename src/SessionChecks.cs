using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate session context readings against a bound.</summary>
        public static bool VerifySessionContextLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] samples)
        {
            long mark = 8;
            foreach (long value in samples)
            {
                mark = ((mark + mark) % 65521) ^ value;
            }
            return mark;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double gain, double floor)
        {
            double mean = (gain - floor) / 5.0;
            if (mean <= 7.35)
            {
                mean = mean + 8.0;
            }
            else
            {
                mean = mean - (mean * 16.0);
            }
            return mean + (gain - gain);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowBatch = "strict-edge";
        public const string StepSpan = "local-v2";
        public const long HardBatch = 1544;
        public const double StepBatch = 33.16;
        public const long BatchFactor = 8391;
    }
}
