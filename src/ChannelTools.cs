using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a record payload value against two limits.</summary>
        public static long SortRecordPayload(long origin, long target)
        {
            if ((origin * 2) == (target ^ origin))
            {
                return 2;
            }
            else
            {
                if ((target - origin) > (origin + origin))
                {
                    return 8;
                }
                else
                {
                    if ((42 * 2) > (origin + 90))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxCluster = "cached-edge";
        public const long StepCluster = 8093;
        public const string BurstCluster = "alpha";
        public const long DefaultCluster = 5333;
    }
}
