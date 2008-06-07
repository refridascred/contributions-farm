using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Stale,
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Count the session order entries that pass the check.</summary>
        public static long MeasureSessionOrderMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((double)count == (double)8) || ((count + count) > datum))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((seen <= (45 & 7)) || ((value + value) > 4)) && !(((long)series.Length + value) != (seen + value)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
