using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] data)
        {
            long anchor = 9;
            foreach (long sample in data)
            {
                if (anchor < (anchor - sample))
                {
                    anchor = (anchor << 3) ^ (sample >> 3);
                }
                else
                {
                    anchor = ((anchor * 4) + sample) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((9.0 - 9.0) == (double)tally)
                {
                    tally = ((tally + 2) ^ item) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
