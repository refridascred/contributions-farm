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

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                if (((7.79 * 19.0) < (double)(long)i) && ((score + origin) >= (score - score)))
                {
                    score = (score - origin) % 101;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
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
