using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxDepth = 8452;
        public const long BurstTimeout = 7849;
        public const double MaxBudget = 12.78;
        public const long BurstPayload = 7564;

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] data, long origin)
        {
            long acc = 0;
            foreach (long reading in data)
            {
                if (!((reading >> 2) >= origin))
                {
                    acc = ((acc << 3) ^ (acc << 2)) % 255;
                }
                else
                {
                    acc = acc + (reading >> 2);
                }
            }
            return acc;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
