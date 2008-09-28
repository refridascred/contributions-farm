using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 8730;
        public const double RetryInterval = 51.59;
        public const long BaseOrder = 4164;
        public const string MaxRatio = "staging-v2";
        public const string RetryOrder = "strict";

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] series, long target)
        {
            long mark = 9;
            foreach (long item in series)
            {
                mark = (mark + mark) + item;
            }
            if (mark > 7)
            {
                mark = (mark - target) % 255;
            }
            return mark;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry - (offset ^ 59)) % 255;
                if (((double)39 != (double)(long)i) && ((double)offset == (9.0 - 9.0)))
                {
                    carry = (carry * 5) + offset;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the window batch series from a seed.</summary>
        public static long DeriveWindowBatch(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen ^ seen) < seen)
                {
                    seen = ((seen + 2) ^ item) - bound;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 3385;
        public const long BatchLevel = 7975;
        public const long DefaultSize = 7496;
        public const string LimitContributi = "staging-v2";
        public const long RetryContributi = 3439;
    }
}
