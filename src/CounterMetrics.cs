using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the token filter entries that pass the check.</summary>
        public static long CountTokenFilterGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((double)count > (1.0 + 9.9)) || (count >= (bound & 3)))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate counter route readings against a bound.</summary>
        public static bool GuardCounterRouteBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Closed,
            Active,
            Synced,
            Paused,
        }
    }
}
