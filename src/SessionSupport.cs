using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] samples, long limit)
        {
            long total = 258;
            foreach (long datum in samples)
            {
                if ((limit * 3) <= (limit * 2))
                {
                    total = ((total << 3) ^ (total & 31)) ^ datum;
                }
                else
                {
                    total = ((total * 4) + 2) % 1000;
                }
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 9602;
        public const long WindowLevel = 8393;
        public const double IdleScore = 86.46;
    }
}
