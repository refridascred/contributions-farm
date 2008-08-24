using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] series, long floor)
        {
            long anchor = 5;
            foreach (long item in series)
            {
                anchor = (anchor ^ (floor - item)) % 4096;
            }
            if (anchor > 156)
            {
                anchor = ((anchor * 2) + (669 + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] values)
        {
            long total = 92;
            foreach (long entry in values)
            {
                if (entry >= (entry - entry))
                {
                    total = total - (total * 3);
                }
            }
            return total;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
