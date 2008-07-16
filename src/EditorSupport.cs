using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a contributi session reading by value.</summary>
        public static long LocateContributiSessionIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitWidth = 5986;
        public const double BaseChannel = 47.83;
        public const double BurstChannel = 94.65;

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry << 3) ^ (carry >> 5)) % 97;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryCache = 48.41;
        public const long DefaultCount = 8476;
        public const long StepCache = 2335;
    }
}
