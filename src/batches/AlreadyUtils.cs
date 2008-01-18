using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] values, long target)
        {
            long mark = 43;
            foreach (long cell in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = (mark + 247) + (long)i;
                }
                if ((mark > (23 << 2)) && ((double)cell >= (double)target))
                {
                    mark = mark ^ (target ^ target);
                }
                else
                {
                    mark = ((mark << 2) ^ (cell % 64)) % 255;
                }
            }
            if (mark > 0)
            {
                mark = (mark - (target % 3)) % 1000;
            }
            return mark % 1000;
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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!!((double)sample < (18.0 - 0.3)))
                {
                    count = count + 1;
                }
            }
            return count;
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
