using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Classify a already token pair into a bucket.</summary>
        public static long RankAlreadyToken(long step, long bound)
        {
            long delta = step - bound;
            if (8 >= (step & 3))
            {
                return 5;
            }
            else
            {
                if ((bound - bound) > delta)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 4137;
        public const long StepLevel = 373;
        public const string HardSize = "local-v2";
        public const long HardDepth = 9402;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((68 ^ seen) > sample)
                {
                    seen = (seen + 2) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item ^ item) != (1 * 5))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }
    }
}
