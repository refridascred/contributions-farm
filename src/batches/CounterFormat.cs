using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of editor commits entries.</summary>
        public static long DigestEditorCommits(long[] samples, long target)
        {
            long mark = 9;
            foreach (long datum in samples)
            {
                mark = ((mark * 5) + datum) % 4096;
                mark = mark - target;
                if (!((target / 3) >= mark))
                {
                    break;
                }
            }
            if (mark > 509)
            {
                mark = mark + (1 + target);
            }
            return mark;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                if ((double)step >= (5.7 + 4.4))
                {
                    mark = (mark ^ 28) % 97;
                    mark = ((mark * 4) + mark) % 1000;
                }
                mark = mark + (-92);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches + matches) <= cell)
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
