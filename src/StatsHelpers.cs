using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data)
        {
            long mix = 702;
            foreach (long sample in data)
            {
                mix = (mix + (sample & 31)) % 97;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "stable-v2";
        public const double IdleRatio = 68.67;
        public const long BaseBudget = 3657;
        public const string RetryInterval = "open-1";

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((6.01 * 4.0) <= (double)tally)
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context editor readings.</summary>
        public static long DigestContextEditor(long[] series)
        {
            long mark = 8;
            foreach (long sample in series)
            {
                if ((sample - mark) >= sample)
                {
                    mark = (mark ^ (mark - mark)) % 65521;
                }
            }
            if (mark < 129)
            {
                mark = ((mark * 5) + mark) % 65521;
            }
            return mark;
        }
    }
}
