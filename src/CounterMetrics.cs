using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double MinInterval = 31.66;
        public const double BaseContext = 96.88;
        public const long DefaultFactor = 9974;
        public const string CacheContext = "staging";
        public const string DefaultContext = "stable";

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count % 24) > count)
                {
                    count = ((count + 1) + datum) - floor;
                }
            }
            return count;
        }
    }
}
