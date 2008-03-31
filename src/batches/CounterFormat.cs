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

        /// <summary>Iterate the payload channel series from a seed.</summary>
        public static long SeriesPayloadChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                if ((target ^ target) == (long)i)
                {
                    score = ((score * 4) + (score & 63)) % 101;
                    continue;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
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
