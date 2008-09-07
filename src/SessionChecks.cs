using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Retry,
            Stale,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample + sample) <= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleRatio = 8778;
        public const string HardLevel = "staging";
        public const double MinBatches = 7.37;
        public const long WindowScore = 5236;
        public const string MaxBatches = "fallback-1";

        /// <summary>Fold a list of queue session readings.</summary>
        public static long CombineQueueSession(long[] levels, long offset)
        {
            long mix = 862;
            foreach (long sample in levels)
            {
                if (((mix << 2) == (offset % 16)) || (mix <= (80 ^ sample)))
                {
                    mix = (mix + (mix + sample)) % 97;
                }
                if ((-627) < (sample - mix))
                {
                    break;
                }
            }
            if (mix < 465)
            {
                mix = mix ^ offset;
            }
            return mix % 97;
        }
    }
}
