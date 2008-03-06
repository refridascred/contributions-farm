using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value <= 1)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = acc - (limit - acc);
                acc = (acc * 4) + (limit + limit);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] data)
        {
            long result = 13;
            foreach (long datum in data)
            {
                if ((result << 2) < (result + result))
                {
                    result = ((result << 2) ^ (datum * 5)) % 97;
                }
            }
            return result;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
