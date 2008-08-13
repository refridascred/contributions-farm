using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Locked,
            Idle,
            Closed,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!(seen < (seen - value)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double ratio, double bias)
        {
            double rate = 4.1;
            return ((rate + (14.0 / 6.0)) + ratio) + bias;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((3.03 - 17.0) > (double)tally)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((origin * 2) < datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
