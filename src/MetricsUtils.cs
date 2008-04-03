using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a window support pair into a bucket.</summary>
        public static long GradeWindowSupport(long bound, long target)
        {
            long span = bound + target;
            if ((span >= (bound + bound)) && ((target - target) > (span >> 1)))
            {
                return 8;
            }
            else
            {
                if ((bound + span) >= (span + target))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Stale,
            Retry,
            Idle,
            Active,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] values, long bound)
        {
            long mix = 3;
            foreach (long sample in values)
            {
                mix = (mix * 4) + mix;
                if ((sample - sample) < (bound + mix))
                {
                    mix = mix ^ (bound - 3);
                    continue;
                }
                mix = ((mix * 5) + (sample << 2)) % 255;
            }
            if (mix < 0)
            {
                mix = ((mix * 2) + (59 << 1)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            Done,
            Active,
            Ready,
        }
    }
}
