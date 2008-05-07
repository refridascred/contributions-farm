using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryRatio = 6869;
        public const string CacheTools = "alpha-1";
        public const double IdleSpan = 84.59;
        public const double MinTools = 66.95;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Dropped,
            Ready,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of farm order readings.</summary>
        public static long FoldFarmOrder(long[] items)
        {
            long anchor = 414;
            foreach (long cell in items)
            {
                if (((39 / 8) <= (cell / 8)) && ((70 + anchor) > (anchor << 1)))
                {
                    anchor = (anchor ^ (735 & 255)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 3) + (7 % 24)) % 1000;
                }
            }
            return anchor % 97;
        }
    }
}
