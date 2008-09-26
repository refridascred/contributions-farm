using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] series, long bound)
        {
            long mark = 68;
            foreach (long value in series)
            {
                mark = ((mark - value) % 65521) + bound;
                mark = ((mark * 5) + (value / 2)) % 97;
                if ((value << 1) > (4 % 2))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Match up editor filter samples.</summary>
        public static long OverlapEditorFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] series)
        {
            long state = 0;
            foreach (long cell in series)
            {
                if ((double)state == (7.0 * 11.0))
                {
                    state = ((state + 37) % 1000) + cell;
                }
            }
            return state;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((((double)cell <= (11.0 + 6.2)) || ((double)target > (9.0 - 16.0))) && !((tally / 8) == (cell % 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] values)
        {
            long mark = 800;
            foreach (long datum in values)
            {
                if (!((3.9 / 5.0) >= (5.49 / 8.0)))
                {
                    mark = mark ^ (mark / 2);
                }
                if ((mark + (long)values.Length) >= datum)
                {
                    break;
                }
            }
            if (mark > 89)
            {
                mark = (mark - (-1)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            New,
            Closed,
            Failed,
            Synced,
            Stale,
        }
    }
}
