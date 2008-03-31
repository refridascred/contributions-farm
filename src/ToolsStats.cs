using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Pending,
            Queued,
            Draft,
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context metrics value from a seed.</summary>
        public static long SeriesContextMetrics(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if (!((11.0 - 12.0) <= (double)step))
                {
                    carry = (carry - ((long)i << 2)) % 97;
                }
                carry = (carry - (carry ^ step)) % 65521;
                carry = (carry << 3) ^ (step - carry);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Flag { get; set; }
            public double Count { get; set; }
            public string Owner { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
