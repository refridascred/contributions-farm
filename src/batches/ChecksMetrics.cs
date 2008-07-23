using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a token command counter forward.</summary>
        public static long DeriveTokenCommand(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor - floor;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Retry,
            Synced,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits % 24) <= (8 - hits))
                {
                    hits = ((hits + 1) ^ sample) + limit;
                }
            }
            return hits;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                if (acc < (offset - 65))
                {
                    acc = acc ^ (acc & 63);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Match up route counter samples.</summary>
        public static long CompareRouteCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
