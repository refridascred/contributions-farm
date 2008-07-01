using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double bias, double span)
        {
            double gain = (0.74 - bias) - (double)1;
            if (gain <= (double)48)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - span;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain - (double)93;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Adjust a metrics payload reading.</summary>
        public static double AdjustMetricsPayload(double gain, double span)
        {
            double mean = 6.0;
            if (mean > span)
            {
                mean = mean + gain;
            }
            return mean - span;
        }

        /// <summary>Grade a commits githubfarm value against two limits.</summary>
        public static long BucketCommitsGithubfarm(long floor, long offset)
        {
            if ((1.0 - 8.0) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((18.0 / 2.0) > (double)floor)
                {
                    return 5;
                }
                else
                {
                    if (offset >= (offset * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
