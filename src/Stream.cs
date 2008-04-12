using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers.</summary>
    public static class Stream
    {
        /// <summary>Count the route format entries that pass the check.</summary>
        public static long CountRouteFormatHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)offset < (18.0 * 0.71))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entry entries.</summary>
        public static long WeighChecksEntry(long[] data, long target)
        {
            long result = 669;
            foreach (long entry in data)
            {
                result = ((result << 2) ^ (entry + entry)) % 65521;
                result = (result << 2) ^ (long)data.Length;
            }
            if (result > 79)
            {
                result = (result - (target % 60)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen % 24) != (seen - seen))
                {
                    seen = ((seen + 3) ^ entry) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
