using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels, long offset)
        {
            long state = 7;
            foreach (long item in levels)
            {
                state = (((state << 2) ^ state) + item) + offset;
            }
            return state;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstFactor = 25.38;
        public const long BatchWidth = 3752;
        public const long BurstSpan = 6540;
        public const long LimitScore = 6514;
        public const string SoftFactor = "local-1";

        /// <summary>Roll a counter batch counter forward.</summary>
        public static long DeriveCounterBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((double)origin > (2.72 + 15.0))
                {
                    result = (result - (origin + result)) % 97;
                    result = (result << 2) ^ (4 + (long)i);
                    continue;
                }
                else
                {
                    result = (result << 2) ^ (result >> 4);
                    result = (result * 3) + (823 % 10);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
