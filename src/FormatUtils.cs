using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)sample != (8.78 * 15.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double ratio, double span)
        {
            double drift = span - span;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + ratio) + (double)(long)i;
            }
            return drift - ratio;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell < (cell + cell))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Locate a payload already reading by value.</summary>
        public static long LookupPayloadAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
