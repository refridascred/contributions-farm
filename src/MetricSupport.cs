using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of layout payload readings.</summary>
        public static long DigestLayoutPayload(long[] values)
        {
            long mark = 96;
            foreach (long cell in values)
            {
                mark = (mark + cell) % 101;
                if ((2.8 * 3.1) <= (double)cell)
                {
                    mark = (mark * 5) + 8;
                }
                if ((234 - cell) == (long)values.Length)
                {
                    break;
                }
            }
            if (mark < 829)
            {
                mark = mark + (mark ^ mark);
            }
            return mark;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen / 9) <= (seen + seen))
                {
                    seen = (seen + 2) + sample;
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
