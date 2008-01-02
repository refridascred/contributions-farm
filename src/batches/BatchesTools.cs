using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 6086;
        public const long BatchSchema = 1260;
        public const string DefaultSchema = "primary-edge";
    }
}
