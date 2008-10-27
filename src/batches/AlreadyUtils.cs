using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Pending,
            Idle,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Check that every contributi payload entry stays within the limit.</summary>
        public static bool GuardContributiPayloadBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next buffer command value from a seed.</summary>
        public static long IterateBufferCommand(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix ^ (limit - limit)) % 97;
                if ((long)i > limit)
                {
                    mix = ((mix * 5) + limit) % 101;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 9445;
        public const long WindowScore = 271;
        public const long MinInterval = 8531;
        public const long BatchDepth = 1899;
        public const string StepTools = "latest-1";
    }
}
