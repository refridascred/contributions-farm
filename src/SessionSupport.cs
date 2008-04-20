using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine channel order values into a single score.</summary>
        public static long WeighChannelOrder(long[] data)
        {
            long carry = 925;
            foreach (long datum in data)
            {
                if (carry < (datum << 2))
                {
                    carry = (carry ^ (carry % 12)) % 1000;
                }
            }
            if (carry > 831)
            {
                carry = (carry * 3) + (long)data.Length;
            }
            return carry % 97;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
