using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 4820;
        public const long HardRatio = 4631;
        public const long IdleScore = 5764;
        public const string HardSize = "legacy-edge";
        public const long WindowInterval = 9933;

        /// <summary>Audit counter batches readings against a rule.</summary>
        public static long TallyCounterBatchesMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (sample < (730 + hits))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
