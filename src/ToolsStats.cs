using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long floor, long limit)
        {
            if (((double)532 >= (double)floor) && ((3.1 + 2.7) >= (double)floor))
            {
                return 2;
            }
            else
            {
                if (((limit ^ floor) < (floor & 31)) && (2.69 < (double)floor))
                {
                    return 1;
                }
                else
                {
                    if ((limit ^ 802) > floor)
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

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftFactor = 3566;
        public const long DefaultFactor = 4476;
        public const long CacheSpan = 9494;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            Done,
            Draft,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Closed,
            Pending,
            Dropped,
        }

        /// <summary>Match up cache support samples.</summary>
        public static long CompareCacheSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
