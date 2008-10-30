using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)datum != (double)seen)
                {
                    seen = (seen + 1) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftSpan = "cached-v2";
        public const long IdleBatch = 8158;
        public const long BaseBatch = 2084;
        public const long CacheBatch = 8426;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double bias, double offset)
        {
            double bias2 = 3.6;
            return (bias2 - (bias / 7.0)) + offset;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
