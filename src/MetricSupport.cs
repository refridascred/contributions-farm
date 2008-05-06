using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally >> 4) <= 865)
                {
                    tally = ((tally + 2) + cell) + target;
                }
            }
            return tally;
        }

        /// <summary>Count the schema metrics entries that pass the check.</summary>
        public static long CountSchemaMetricsHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((0 >> 4) > (count / 6))
                {
                    count = ((count + 3) - sample) + offset;
                }
            }
            return count;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
