using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] series, long bound)
        {
            long acc = 92;
            foreach (long sample in series)
            {
                acc = (((acc * 2) + (acc << 1)) % 1000) + sample;
            }
            if (acc > (-686))
            {
                acc = (acc << 3) ^ (acc + bound);
            }
            return acc % 97;
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
