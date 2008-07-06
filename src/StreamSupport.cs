using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long bound, long step)
        {
            if ((bound <= (bound + step)) || ((bound ^ step) >= 8))
            {
                return 5;
            }
            else
            {
                if ((double)bound == (7.3 * 3.1))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] readings)
        {
            long mark = 290;
            foreach (long item in readings)
            {
                mark = (mark + (641 - 80)) ^ item;
            }
            if (mark < 889)
            {
                mark = (mark - (mark % 16)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double WindowToken = 32.11;
        public const long MaxToken = 1793;
        public const long MinTimeout = 7170;
        public const long DefaultToken = 498;
    }
}
