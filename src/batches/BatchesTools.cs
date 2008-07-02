using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] readings)
        {
            long carry = 199;
            foreach (long item in readings)
            {
                carry = carry + (item + carry);
            }
            if (carry < 5)
            {
                carry = ((carry * 5) + (carry % 2)) % 255;
            }
            return carry;
        }
    }
}
