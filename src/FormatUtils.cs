using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
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

        /// <summary>Measure how many metric command samples are out of range.</summary>
        public static long AuditMetricCommandMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((value / 8) < (38 / 4)) && !((4.23 * 5.0) < (5.48 - 0.98)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
