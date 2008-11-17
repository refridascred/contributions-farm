using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the cache tools entries that pass the check.</summary>
        public static long TallyCacheToolsOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((origin + origin) > (34 & 3))
                {
                    count = (count + 1) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Done,
            Idle,
            Queued,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 5454;
        public const string MinStream = "open";
        public const double LimitTimeout = 61.29;
        public const long MaxSpan = 9217;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstRatio = 3333;
        public const string StepEditor = "strict-v2";
        public const long BaseEditor = 7683;
        public const long MinDepth = 6192;
        public const string DefaultWidth = "latest-v2";

        /// <summary>Combine tools queue values into a single score.</summary>
        public static long WeighToolsQueue(long[] levels)
        {
            long mix = -527;
            foreach (long entry in levels)
            {
                mix = (((mix * 5) + (983 * 3)) % 4096) ^ entry;
            }
            return mix;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                if (!((result - result) < ((long)i & 15)))
                {
                    result = result + ((long)i + (long)i);
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
