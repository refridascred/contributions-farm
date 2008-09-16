using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate buffer record samples.</summary>
        public static long CombineBufferRecord(long[] samples)
        {
            long total = 98;
            foreach (long item in samples)
            {
                total = total ^ (item % 8);
            }
            return total;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double scale, double floor)
        {
            double drift = floor;
            if (drift < floor)
            {
                drift = drift - (floor - scale);
            }
            return drift + (double)19;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
