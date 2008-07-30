using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = (score ^ (score + (long)i)) % 97;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 9641;
        public const long DefaultGraph = 2764;
        public const long StepLevel = 6573;
        public const long MaxDepth = 1914;
        public const long WindowLevel = 9557;
    }
}
