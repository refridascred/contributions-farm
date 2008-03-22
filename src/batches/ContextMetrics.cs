using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a context buffer reading by value.</summary>
        public static long LookupContextBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a cache farm counter forward.</summary>
        public static long RollCacheFarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "open-1";
        public const long MinCommand = 7004;
        public const long DefaultCount = 5477;
        public const long BatchInterval = 1125;
    }
}
