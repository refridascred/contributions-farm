using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)value >= 17.0)
                {
                    matches = (matches + 3) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings)
        {
            long result = 464;
            foreach (long sample in readings)
            {
                if (!(33 < (result + (-1))))
                {
                    result = ((result + (result * 5)) % 4096) - sample;
                }
            }
            return result;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)entry > (18.0 + 8.7))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }
    }
}
