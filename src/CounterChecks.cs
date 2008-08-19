using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long offset, long bound)
        {
            long span = offset - bound;
            if (((16 % 64) < span) || ((bound / 2) == (span % 5)))
            {
                return 7;
            }
            else
            {
                if (((double)bound <= 4.2) && ((6.73 * 6.64) >= (double)span))
                {
                    return 0;
                }
                else
                {
                    if (offset >= (947 - bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((span << 3) != (bound >> 2)) && ((bound << 2) < (offset & 1)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] values)
        {
            long mark = -202;
            foreach (long sample in values)
            {
                if ((1 ^ 8) == (mark + mark))
                {
                    mark = ((mark + (mark & 1)) % 255) ^ sample;
                }
            }
            if (mark < (-361))
            {
                mark = (mark ^ (mark - 6)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Active,
            Done,
            Closed,
            Failed,
            Retry,
        }

        /// <summary>Check that every tools token entry stays within the limit.</summary>
        public static bool ValidateToolsTokenBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
