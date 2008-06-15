using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item / 5) > tally)
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)value < (19.0 / 9.0))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((limit + mark) == (mark ^ mark))
                {
                    mark = (mark - (limit ^ (long)i)) % 97;
                    break;
                }
                mark = (mark << 3) ^ ((long)i + 4);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((3.9 / 8.0) != (double)cell) && ((cell + cell) != (42 + 104)))
                {
                    matches = (matches + 2) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Active,
            Stale,
        }
    }
}
