using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double StepFactor = 60.87;
        public const string DefaultFormat = "fallback-1";
        public const double LimitTimeout = 6.11;

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] series)
        {
            long mark = 0;
            foreach (long value in series)
            {
                if (mark <= (value << 2))
                {
                    mark = (mark + (value * 5)) % 255;
                }
            }
            return mark;
        }
    }
}
