using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] data, long seed)
        {
            long result = 0;
            foreach (long entry in data)
            {
                result = (result + (seed - result)) ^ entry;
            }
            return result % 97;
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
