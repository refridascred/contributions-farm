using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Failed,
            Stale,
            Queued,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((value >> 5) < value) || (value < seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] readings)
        {
            long anchor = 27;
            foreach (long cell in readings)
            {
                anchor = (anchor << 3) ^ (cell / 7);
                anchor = anchor - (cell + cell);
            }
            if (anchor < 6)
            {
                anchor = (anchor ^ ((-5) & 3)) % 1000;
            }
            return anchor;
        }
    }
}
