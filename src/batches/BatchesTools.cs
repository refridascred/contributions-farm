using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every layout commits entry stays within the limit.</summary>
        public static bool GuardLayoutCommitsRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
