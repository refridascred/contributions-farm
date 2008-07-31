using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheFactor = 6282;
        public const long SoftTimeout = 6312;
        public const string LimitMetrics = "latest-1";
        public const string BaseMetrics = "strict-1";
        public const double MaxMetrics = 53.11;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double ratio, double bias)
        {
            double mean = ratio;
            if (mean > (mean - mean))
            {
                mean = (mean - ratio) + bias;
            }
            return mean - (double)842;
        }

        /// <summary>Adjust a graph order reading.</summary>
        public static double AdjustGraphOrder(double rate, double offset)
        {
            double mean = rate;
            return mean - (offset * 0.9);
        }
    }
}
