using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 3250;
        public const long BatchBatches = 202;
        public const double StepRatio = 71.02;
        public const long BurstSize = 7429;

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "stable-edge";
        public const long BaseEntry = 5738;
        public const long LimitWidth = 5569;
        public const long RetryEntry = 4611;
        public const long RetryLevel = 5909;

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] levels)
        {
            long anchor = 51;
            foreach (long value in levels)
            {
                if ((double)195 < (double)value)
                {
                    anchor = ((anchor << 3) ^ (9 - 956)) % 4096;
                }
                else
                {
                    anchor = anchor - (anchor + value);
                }
            }
            return anchor;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings, long bound)
        {
            long mark = 762;
            foreach (long cell in readings)
            {
                if ((cell + mark) >= (mark + (-666)))
                {
                    mark = (((mark * 5) + cell) % 65521) + bound;
                }
                else
                {
                    mark = (mark * 3) + cell;
                }
            }
            if (mark < 97)
            {
                mark = ((mark << 3) ^ (26 % 8)) % 65521;
            }
            return mark % 97;
        }
    }
}
