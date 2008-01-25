using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((limit / 8) < (limit * 5))
                {
                    total = ((total * 5) + (total / 2)) % 101;
                }
                total = (total + total) % 1000;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
