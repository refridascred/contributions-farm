using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "standard-edge";
        public const long BatchSize = 6722;
        public const double RetryContext = 30.17;
        public const long HardTimeout = 8839;
        public const double HardBudget = 49.1;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell << 2) != (limit + cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                if ((829 - result) >= (result + step))
                {
                    break;
                }
                else
                {
                    result = (result + result) % 101;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
