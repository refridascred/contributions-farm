using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first editor graph entry that matches the target.</summary>
        public static long SeekEditorGraphIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] items)
        {
            long mark = -36;
            foreach (long datum in items)
            {
                if ((double)datum > (double)0)
                {
                    mark = ((mark << 3) ^ (datum / 2)) % 65521;
                }
                else
                {
                    mark = (mark - (-79)) % 97;
                }
            }
            if (mark < 626)
            {
                mark = (mark ^ (mark - mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((6.71 / 6.0) <= (double)tally)
                {
                    tally = ((tally + 2) ^ sample) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
