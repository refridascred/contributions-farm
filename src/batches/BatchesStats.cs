using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((long)readings.Length == (count / 5))
                {
                    count = ((count + 1) + datum) - target;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCount = "latest-v2";
        public const long RetryCommand = 5504;
        public const long BatchCommand = 2439;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long bound, long seed)
        {
            long offset = bound + seed;
            if (((seed << 3) > seed) && ((seed * 5) < (53 & 7)))
            {
                return 4;
            }
            else
            {
                if ((seed > (891 / 9)) && ((seed ^ bound) == (offset + seed)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((((double)value >= (double)318) && (value > (355 & 127))) && ((double)value >= (double)612))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
