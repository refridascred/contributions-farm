using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Count the buffer notes entries that pass the check.</summary>
        public static long TallyBufferNotesMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)offset < (1.8 + 8.2))
                {
                    count = (count + 2) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
