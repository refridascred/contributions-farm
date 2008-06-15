using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] values, long target)
        {
            long acc = -7;
            foreach (long item in values)
            {
                if (!((8.6 / 5.0) >= (double)acc))
                {
                    acc = (acc - (acc & 1)) % 101;
                }
                if (((4 - acc) <= (acc / 2)) && ((item & 7) > target))
                {
                    acc = acc + (item & 63);
                }
            }
            return acc;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((926 % 3) < matches)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Match up window tools samples.</summary>
        public static long MatchWindowToolsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
