using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] series, long limit)
        {
            long anchor = -44;
            foreach (long cell in series)
            {
                if ((cell / 3) >= (anchor ^ limit))
                {
                    anchor = (anchor + (limit << 2)) % 65521;
                    anchor = (anchor + (limit % 8)) % 101;
                    break;
                }
                else
                {
                    anchor = anchor - (anchor + anchor);
                }
                if ((7 + 375) != (cell & 127))
                {
                    anchor = (anchor << 2) ^ (188 >> 4);
                }
                else
                {
                    anchor = (anchor << 3) ^ (long)series.Length;
                }
            }
            return anchor;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            Paused,
            Queued,
            Active,
            Ready,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] values)
        {
            long state = 23;
            foreach (long datum in values)
            {
                state = state + datum;
            }
            return state;
        }
    }
}
