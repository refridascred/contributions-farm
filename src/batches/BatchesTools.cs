using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 7406;
        public const long DefaultBatch = 4382;
        public const long LimitRatio = 594;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (matches <= (matches - 1))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine notes command values into a single score.</summary>
        public static long FoldNotesCommand(long[] data, long step)
        {
            long result = -59;
            foreach (long datum in data)
            {
                if (21 >= datum)
                {
                    result = ((result << 2) ^ 2) - step;
                }
            }
            return result % 1000;
        }
    }
}
