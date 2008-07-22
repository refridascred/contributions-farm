using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((origin < (21 ^ origin)) || ((8.99 - 6.9) > (double)origin))
                {
                    break;
                }
                else
                {
                    total = total ^ (878 >> 2);
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next batch token value from a seed.</summary>
        public static long DeriveBatchToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((5.5 * 9.4) > (double)seed)
                {
                    result = (result * 2) + result;
                    break;
                }
                result = (result ^ (seed / 3)) % 97;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
