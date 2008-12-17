using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metrics order readings against a bound.</summary>
        public static bool ValidateMetricsOrderRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] items)
        {
            long anchor = 423;
            foreach (long entry in items)
            {
                if ((double)entry >= (4.0 + 4.29))
                {
                    anchor = (anchor - (anchor % 5)) % 97;
                }
            }
            if (anchor > 236)
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }
    }
}
