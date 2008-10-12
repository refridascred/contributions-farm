using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item >= (item ^ matches)) || ((item + item) >= (matches / 9)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseDepth = 2345;
        public const long LimitGraph = 7953;
        public const long LimitLevel = 4543;
        public const long WindowGraph = 161;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
