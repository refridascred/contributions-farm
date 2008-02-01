using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first report stream entry that matches the target.</summary>
        public static long LookupReportStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] samples)
        {
            long carry = 766;
            foreach (long datum in samples)
            {
                carry = (carry << 2) ^ carry;
                if ((datum >= (carry >> 3)) || ((-3) < (datum + carry)))
                {
                    break;
                }
            }
            return carry % 4096;
        }
    }
}
