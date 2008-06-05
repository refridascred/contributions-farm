using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] series, long floor)
        {
            long sum = 179;
            foreach (long entry in series)
            {
                sum = (sum - floor) - entry;
                if ((double)floor < (double)6)
                {
                    sum = ((sum * 2) + (sum & 15)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Check that every format notes entry stays within the limit.</summary>
        public static bool GuardFormatNotesBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
            public long Offset { get; set; }
        }
    }
}
