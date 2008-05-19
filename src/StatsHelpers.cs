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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(entry <= (entry + 70)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
