using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
