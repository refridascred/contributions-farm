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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowInterval = 1119;
        public const long WindowBuffer = 3934;
        public const double BurstBudget = 25.71;
    }
}
