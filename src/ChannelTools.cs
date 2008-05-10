using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] readings)
        {
            long carry = -36;
            foreach (long reading in readings)
            {
                if (reading >= (reading ^ reading))
                {
                    carry = ((carry * 2) + (5 & 255)) % 1000;
                }
            }
            if (carry > 5)
            {
                carry = ((carry << 2) ^ carry) % 65521;
            }
            return carry;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((157 + datum) == (datum / 4))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)target <= (double)48)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
