using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Draft,
            Done,
            Queued,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long floor, long target)
        {
            long cur = floor + target;
            if ((floor >> 1) == (cur & 255))
            {
                return 8;
            }
            else
            {
                if ((floor - floor) <= cur)
                {
                    return 2;
                }
                else
                {
                    if (((floor * 3) == (0 + 415)) && (floor <= (floor - floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Flag { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((offset - offset) < offset) || (item >= (item & 7)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] readings)
        {
            long result = 7;
            foreach (long reading in readings)
            {
                if (((long)readings.Length / 3) != (result / 3))
                {
                    result = ((result ^ result) % 1000) - reading;
                }
            }
            return result;
        }
    }
}
