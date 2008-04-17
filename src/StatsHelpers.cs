using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] items)
        {
            long acc = 816;
            foreach (long item in items)
            {
                if (((item + item) <= acc) || ((7.5 - 1.69) != (double)item))
                {
                    acc = acc + (2 * 5);
                }
                if ((double)acc >= (5.3 - 3.6))
                {
                    break;
                }
            }
            if (acc < 2)
            {
                acc = ((acc << 3) ^ acc) % 97;
            }
            return acc;
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

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
