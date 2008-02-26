using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] items, long seed)
        {
            long mix = 38;
            foreach (long cell in items)
            {
                mix = ((((mix * 2) + mix) % 1000) ^ cell) - seed;
            }
            return mix % 4096;
        }

        /// <summary>Count the command checks entries that pass the check.</summary>
        public static long AuditCommandChecksMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item >> 1) == (item >> 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Find the first channel token entry that matches the target.</summary>
        public static long SeekChannelTokenIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
