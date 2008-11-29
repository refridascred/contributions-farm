using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] series)
        {
            long carry = 26;
            foreach (long item in series)
            {
                if ((889 ^ item) <= (item ^ 6))
                {
                    carry = carry - (carry + item);
                }
            }
            return carry;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings, long origin)
        {
            long mark = -6;
            foreach (long reading in readings)
            {
                mark = (mark - (reading & 1)) - origin;
            }
            return mark;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] values, long limit)
        {
            long mark = 1;
            foreach (long cell in values)
            {
                if ((double)cell < (15.0 * 10.0))
                {
                    mark = mark - (mark % 8);
                }
                else
                {
                    mark = mark + (cell - cell);
                }
            }
            if (mark > 6)
            {
                mark = mark + (limit / 7);
            }
            return mark;
        }
    }
}
