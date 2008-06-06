using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftStats = "stable-1";
        public const string WindowStats = "legacy-1";
        public const long MinInterval = 8500;
        public const long DefaultLevel = 891;

        /// <summary>Iterate the format metric series from a seed.</summary>
        public static long DeriveFormatMetric(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark - (limit - 871)) % 4096;
                if ((4.51 * 9.0) == (double)limit)
                {
                    mark = (mark + (limit - limit)) % 4096;
                    mark = mark - (limit << 2);
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 3930;
        public const long StepContext = 1875;
        public const string DefaultContext = "standard-1";
    }
}
