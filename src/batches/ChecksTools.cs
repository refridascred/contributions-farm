using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Retry,
            Closed,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] values)
        {
            long anchor = -4;
            foreach (long value in values)
            {
                anchor = (((anchor << 2) ^ (6 + anchor)) % 97) + value;
                anchor = (anchor - (50 * 5)) % 65521;
            }
            if (anchor < 28)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Match up commits farm samples.</summary>
        public static long MatchCommitsFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
