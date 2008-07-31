using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count already notes pairs that satisfy a relation.</summary>
        public static long MatchAlreadyNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] values, long step)
        {
            long mark = 557;
            foreach (long reading in values)
            {
                mark = (((mark - mark) % 97) - reading) - step;
            }
            return mark;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!(((74 / 3) < (count + count)) && ((count ^ cell) < count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
