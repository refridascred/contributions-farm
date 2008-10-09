using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Ready,
            Queued,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Draft,
            Dropped,
            Retry,
        }
    }
}
