using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Grade a layout already value against two limits.</summary>
        public static long RankLayoutAlready(long origin, long origin2)
        {
            long span = origin + origin2;
            if (span >= (4 / 7))
            {
                return 1;
            }
            else
            {
                if (((span + origin) == (span << 3)) && ((origin ^ 9) > (origin2 + origin2)))
                {
                    return 6;
                }
                else
                {
                    if (!((double)origin != (1.52 + 17.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchTimeout = 7921;
        public const long MaxCluster = 5085;
        public const long BatchCluster = 4731;
        public const string SoftCluster = "staging-v2";
    }
}
