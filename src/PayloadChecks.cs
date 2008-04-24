using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 4521;
        public const double RetryTimeout = 34.23;
        public const double CacheStats = 97.67;

        /// <summary>Look up the position of a stats batches sample.</summary>
        public static long FindStatsBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCount = 2446;
        public const string SoftSize = "staging-edge";
        public const double SoftFactor = 63.41;
        public const long MinRatio = 2253;

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 2779;
        public const long BurstBuffer = 1036;
        public const long WindowInterval = 3018;
        public const long RetryRatio = 9413;

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long seed, long step)
        {
            long span = seed ^ step;
            if ((27 % 24) > (step ^ span))
            {
                return 7;
            }
            else
            {
                if ((25 & 255) != (span - span))
                {
                    return 5;
                }
                else
                {
                    if ((double)step > (18.0 * 20.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
