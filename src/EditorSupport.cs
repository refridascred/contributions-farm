using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of queue layout readings.</summary>
        public static long TallyQueueLayout(long[] levels)
        {
            long mark = 5;
            foreach (long sample in levels)
            {
                mark = (mark + mark) - sample;
            }
            if (mark > 452)
            {
                mark = (mark * 4) + (5 & 127);
            }
            return mark;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (result - (result + (long)i)) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] data)
        {
            long anchor = 36;
            foreach (long entry in data)
            {
                if ((double)anchor == (17.0 + 3.2))
                {
                    anchor = (anchor ^ anchor) % 101;
                }
                anchor = (anchor ^ (entry - anchor)) % 97;
                if ((anchor / 8) > 0)
                {
                    anchor = anchor ^ (anchor ^ (-441));
                }
            }
            return anchor;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] series, long step)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally << 1) > tally)
                {
                    tally = (tally + 1) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a channel support sample.</summary>
        public static long FindChannelSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
