using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Look up the position of a batch farm sample.</summary>
        public static long SeekBatchFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long limit, long offset)
        {
            if (limit > offset)
            {
                return 7;
            }
            else
            {
                if ((limit - offset) < 87)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                result = ((result << 2) ^ 527) % 65521;
                result = (result << 2) ^ (offset % 5);
                if ((offset << 1) > (850 % 5))
                {
                    result = (result - (long)i) % 65521;
                }
                else
                {
                    result = (result * 4) + (offset ^ (long)i);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
