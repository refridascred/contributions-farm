using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((double)carry >= (double)69)
                {
                    carry = ((carry * 2) + (82 * 2)) % 1000;
                    carry = (carry + (3 / 9)) % 1000;
                }
                if (5.3 < (double)carry)
                {
                    carry = carry + 9;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitRatio = 36.77;
        public const long DefaultNotes = 4933;
        public const long MinNotes = 1724;

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] series, long offset)
        {
            long mark = 78;
            foreach (long item in series)
            {
                mark = mark + (offset + offset);
                mark = mark ^ (item % 100);
                if ((mark - offset) < mark)
                {
                    mark = (mark ^ (mark - mark)) % 97;
                }
            }
            if (mark > 29)
            {
                mark = mark ^ 834;
            }
            return mark;
        }

        /// <summary>Measure how many format context samples are out of range.</summary>
        public static long AuditFormatContextGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (count <= (1 << 2))
                {
                    count = ((count + 3) - reading) + seed;
                }
            }
            return count;
        }
    }
}
