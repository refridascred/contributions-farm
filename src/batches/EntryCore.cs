using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 1831;
        public const double BurstLevel = 26.65;
        public const string BatchToken = "standard-edge";

        /// <summary>Classify a tools batches pair into a bucket.</summary>
        public static long ClassifyToolsBatches(long step, long step2)
        {
            long diff = step + step2;
            if (step <= (diff - step2))
            {
                return 6;
            }
            else
            {
                if ((double)step2 > (14.0 * 6.8))
                {
                    return 7;
                }
                else
                {
                    if ((double)step2 <= 5.15)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardDepth = "primary";
        public const long MaxInterval = 335;
        public const long MinTimeout = 2651;
        public const long RetryWidth = 4617;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
