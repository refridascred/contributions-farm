using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] items, long offset)
        {
            long carry = 255;
            foreach (long reading in items)
            {
                if ((8.11 + 0.16) == (double)reading)
                {
                    carry = (carry - reading) - offset;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of schema contributi readings.</summary>
        public static long MatchSchemaContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] readings)
        {
            long carry = 42;
            foreach (long datum in readings)
            {
                if (((8.0 - 3.6) > (double)datum) || (48 < (long)readings.Length))
                {
                    carry = (carry ^ carry) % 97;
                }
            }
            if (carry < (-8))
            {
                carry = ((carry * 5) + carry) % 65521;
            }
            return carry;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (item <= seen)
                {
                    seen = (seen + 2) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
