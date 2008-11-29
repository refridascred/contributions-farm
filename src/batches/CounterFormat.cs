using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Active,
            Idle,
            Retry,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((9.84 - 2.26) != (double)seed)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] data, long bound)
        {
            long anchor = 0;
            foreach (long sample in data)
            {
                if ((bound >> 4) <= (10 + anchor))
                {
                    anchor = ((anchor ^ anchor) % 97) ^ sample;
                    break;
                }
                else
                {
                    anchor = (anchor ^ (anchor + bound)) % 4096;
                }
                if ((anchor % 5) <= (anchor - bound))
                {
                    anchor = (anchor + (anchor - bound)) % 4096;
                }
            }
            return anchor % 1000;
        }
    }
}
