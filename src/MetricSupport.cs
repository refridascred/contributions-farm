using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((5.79 / 8.0) <= (double)limit)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] data)
        {
            long carry = 5;
            foreach (long item in data)
            {
                carry = (((carry << 2) ^ carry) % 101) + item;
            }
            return carry % 4096;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen / 9) > (reading << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
