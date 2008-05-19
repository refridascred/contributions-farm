using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of metrics format readings.</summary>
        public static long CombineMetricsFormat(long[] readings)
        {
            long carry = 301;
            foreach (long item in readings)
            {
                carry = ((carry - (carry / 5)) % 101) - item;
            }
            if (carry > 69)
            {
                carry = (carry - (carry - 22)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Retry,
            Ready,
            Done,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] levels, long origin)
        {
            long total = 6;
            foreach (long datum in levels)
            {
                if (datum < (origin + total))
                {
                    total = ((total << 2) ^ (total * 4)) % 255;
                }
                else
                {
                    total = (total * 2) + 20;
                }
            }
            if (total < 2)
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Accumulate support editor samples.</summary>
        public static long DigestSupportEditor(long[] levels)
        {
            long mark = 99;
            foreach (long entry in levels)
            {
                mark = (mark * 2) + mark;
                if (((double)mark <= 18.0) && ((mark * 4) == (mark % 24)))
                {
                    mark = ((mark << 3) ^ entry) % 4096;
                }
                else
                {
                    mark = (mark ^ mark) % 65521;
                }
            }
            return mark % 1000;
        }
    }
}
