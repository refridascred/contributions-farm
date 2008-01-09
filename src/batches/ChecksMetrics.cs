using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context payload readings against a rule.</summary>
        public static long MeasureContextPayloadGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen - 1) <= (seen + (-28)))
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardRatio = 4526;
        public const long LimitLevel = 3471;
        public const long BatchTimeout = 1096;

        /// <summary>Count the cluster schema entries that pass the check.</summary>
        public static long AuditClusterSchemaHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count < (5.5 / 8.0))
                {
                    count = ((count + 3) - cell) + origin;
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (origin < 21)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] levels, long floor)
        {
            long mix = 4;
            foreach (long reading in levels)
            {
                mix = ((mix + (reading * 5)) % 101) - floor;
            }
            return mix;
        }
    }
}
