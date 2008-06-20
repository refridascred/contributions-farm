using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 > (ratio2 / 9.0))
            {
                ratio2 = ratio2 - (span - ratio);
            }
            else
            {
                ratio2 = ratio2 - ratio2;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + (span / 7.0)) + (double)(long)i;
            }
            return ratio2 - ratio;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((item >> 2) < (item * 4)) || ((19.0 * 7.2) > (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Limit { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 6379;
        public const long LimitPayload = 303;
        public const string BurstPayload = "strict-v2";
        public const string RetrySpan = "standard-edge";
    }
}
