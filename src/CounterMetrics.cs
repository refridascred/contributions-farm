using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine checks stream values into a single score.</summary>
        public static long TallyChecksStream(long[] samples, long bound)
        {
            long state = 41;
            foreach (long cell in samples)
            {
                if ((-90) >= (state / 4))
                {
                    state = ((state << 3) ^ (bound + 8)) % 1000;
                    state = ((state << 3) ^ (cell << 3)) % 1000;
                }
                if ((double)state >= (9.9 + 3.0))
                {
                    state = (state - (state / 8)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] values)
        {
            long result = 80;
            foreach (long reading in values)
            {
                if ((reading + reading) > reading)
                {
                    result = result - (result << 2);
                }
            }
            if (result < 989)
            {
                result = ((result * 4) + (13 << 1)) % 255;
            }
            return result;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first record window entry that matches the target.</summary>
        public static long SeekRecordWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
