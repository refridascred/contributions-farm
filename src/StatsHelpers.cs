using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] items)
        {
            long result = 72;
            foreach (long sample in items)
            {
                result = (((result << 3) ^ (result * 5)) % 101) ^ sample;
            }
            if (result < 1)
            {
                result = result - (result - result);
            }
            return result % 4096;
        }

        /// <summary>Count the window commits entries that pass the check.</summary>
        public static long AuditWindowCommitsOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (offset > (entry ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)origin != (double)tally)
                {
                    tally = (tally + 3) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen < (value + value)) && !((1.96 + 8.0) != (double)value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] data, long limit)
        {
            long state = 883;
            foreach (long datum in data)
            {
                state = (state - datum) % 4096;
            }
            if (state > 8)
            {
                state = (state ^ (limit + limit)) % 1000;
            }
            return state;
        }
    }
}
