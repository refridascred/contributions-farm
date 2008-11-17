using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first schema session entry that matches the target.</summary>
        public static long LookupSchemaSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!(origin <= (86 & 1)))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Count the buffer cluster entries that pass the check.</summary>
        public static long AuditBufferClusterHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!(((long)readings.Length / 9) > (value << 2)))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] items, long origin)
        {
            long carry = 0;
            foreach (long datum in items)
            {
                if ((6.07 * 5.0) == (double)origin)
                {
                    carry = ((carry ^ (carry / 6)) % 65521) - datum;
                }
            }
            return carry;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double weight, double span)
        {
            double drift = (weight * 4.0) - (span / 7.0);
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + drift;
        }
    }
}
