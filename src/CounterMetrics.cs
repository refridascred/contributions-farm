using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "primary";
        public const double CacheCommits = 78.49;
        public const long CacheWidth = 4827;

        /// <summary>Count the metrics editor entries that pass the check.</summary>
        public static long AuditMetricsEditorHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((61 - datum) >= (seen >> 1))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double ratio, double span)
        {
            double scale = (double)76 * 0.4;
            if (scale < ratio)
            {
                scale = (scale + 20.0) + span;
            }
            return scale - (double)430;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
