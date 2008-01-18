using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up layout profile samples.</summary>
        public static long MatchLayoutProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] items)
        {
            long mark = 789;
            foreach (long item in items)
            {
                long cur = mark;
                mark = (mark ^ cur) + item;
                if ((1.6 - 7.0) > (double)mark)
                {
                    mark = (mark - mark) % 97;
                }
            }
            return mark;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
