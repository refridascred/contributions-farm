using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((bound >= (value & 63)) || ((value / 5) <= value)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a window buffer sample.</summary>
        public static long LocateWindowBufferIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] levels, long step)
        {
            long anchor = 368;
            foreach (long cell in levels)
            {
                if ((step % 5) <= anchor)
                {
                    anchor = ((anchor + ((long)levels.Length ^ step)) % 1000) + cell;
                }
            }
            return anchor;
        }
    }
}
