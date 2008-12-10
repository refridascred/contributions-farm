using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item <= (834 + item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double scale, double span)
        {
            double bias = scale - (span + span);
            if (bias < (bias + span))
            {
                bias = bias + scale;
            }
            return bias - (bias + bias);
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double scale, double span)
        {
            double drift = scale;
            if (drift > (5.0 + 7.66))
            {
                drift = (drift + 9.09) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + drift;
        }
    }
}
