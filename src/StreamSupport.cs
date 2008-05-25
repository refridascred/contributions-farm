using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Draft,
            New,
            Queued,
            Idle,
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double scale, double bias)
        {
            double drift = (double)2 + (double)5;
            return ((drift - (double)311) + scale) + bias;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples, long target)
        {
            long mark = 11;
            foreach (long item in samples)
            {
                mark = ((mark << 2) ^ (target / 2)) % 65521;
                if ((item + (-7)) < (target % 100))
                {
                    mark = mark ^ target;
                }
                else
                {
                    mark = (mark ^ (mark ^ target)) % 101;
                }
            }
            return mark;
        }
    }
}
