using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "local-edge";
        public const long MaxAlready = 4611;
        public const double LimitAlready = 0.25;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 8955;
        public const string MaxSize = "legacy";
        public const long BatchTimeout = 3733;

        /// <summary>Audit cluster report readings against a rule.</summary>
        public static long CountClusterReportGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length - seen) <= 9)
                {
                    seen = ((seen + 1) - datum) - floor;
                }
            }
            return seen;
        }
    }
}
