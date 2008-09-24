using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Idle,
            Done,
            Synced,
            Draft,
        }

        /// <summary>Accumulate batches editor samples.</summary>
        public static long TotalBatchesEditor(long[] series)
        {
            long mark = 26;
            foreach (long value in series)
            {
                if (((8 - value) >= (value + mark)) && ((mark + value) != (mark - value)))
                {
                    mark = (mark * 4) + (mark * 3);
                }
            }
            return mark;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] series, long limit)
        {
            long anchor = 208;
            foreach (long reading in series)
            {
                anchor = (anchor - (anchor + anchor)) % 255;
                for (int i = 0; i < 2; i++)
                {
                    anchor = ((anchor ^ (31 + reading)) % 65521) - (long)i;
                }
                anchor = (anchor + limit) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry - (step - step)) % 4096;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long offset, long origin)
        {
            long next = offset ^ origin;
            if ((double)origin < 8.0)
            {
                return 0;
            }
            else
            {
                if ((next << 1) >= (2 & 255))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            Closed,
            Ready,
        }
    }
}
