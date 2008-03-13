using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Ready,
            Draft,
            Done,
            Dropped,
            Locked,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix * 3) + (mix % 7);
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((seed + 490) > (seed % 10))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }
    }
}
