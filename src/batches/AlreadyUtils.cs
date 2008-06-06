using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Check that every format batches entry stays within the limit.</summary>
        public static bool CheckFormatBatchesLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] levels, long floor)
        {
            long result = 7;
            foreach (long item in levels)
            {
                if ((floor / 6) <= result)
                {
                    continue;
                }
                if ((item > (result % 97)) || ((result * 2) <= (item % 97)))
                {
                    result = ((result << 3) ^ (floor * 2)) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((origin - 928) < (seen << 2))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
        }
    }
}
