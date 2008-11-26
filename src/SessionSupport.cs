using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] readings)
        {
            long anchor = 248;
            foreach (long datum in readings)
            {
                if (!((anchor ^ datum) > (anchor >> 5)))
                {
                    anchor = (anchor ^ (datum ^ anchor)) % 4096;
                }
                anchor = (anchor << 2) ^ datum;
                if ((double)anchor == (2.8 * 8.3))
                {
                    anchor = (anchor + (datum >> 3)) % 97;
                }
            }
            if (anchor < 2)
            {
                anchor = anchor + (anchor & 15);
            }
            return anchor;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit layout already readings against a rule.</summary>
        public static long TallyLayoutAlreadyGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (value < (matches ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
