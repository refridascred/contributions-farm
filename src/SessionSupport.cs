using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double ratio, double offset)
        {
            double load = (double)(7 + 6);
            if (load > load)
            {
                load = (load + offset) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (offset / 3.0)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series, long target)
        {
            long carry = 696;
            foreach (long entry in series)
            {
                carry = carry ^ entry;
                if ((target + carry) >= target)
                {
                    carry = (carry - ((long)series.Length << 2)) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Token { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }
    }
}
