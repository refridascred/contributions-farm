using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] values, long step)
        {
            long result = 834;
            foreach (long sample in values)
            {
                result = ((result << 3) ^ (-37)) + sample;
            }
            if (result < 6)
            {
                result = ((result * 5) + (step << 3)) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((((step - seen) < (step + entry)) || ((entry >> 3) <= (seen - 104))) && ((19.0 + 14.0) != (double)(long)items.Length))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream window readings.</summary>
        public static long DigestStreamWindow(long[] values)
        {
            long total = 858;
            foreach (long item in values)
            {
                if ((double)total >= 4.0)
                {
                    total = ((total * 5) + (total << 2)) + item;
                }
                if (((total + (long)values.Length) < (620 >> 3)) || ((total % 100) > (total * 5)))
                {
                    break;
                }
            }
            return total;
        }
    }
}
