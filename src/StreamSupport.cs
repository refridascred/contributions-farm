using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long bound, long step)
        {
            if ((bound <= (bound + step)) || ((bound ^ step) >= 8))
            {
                return 5;
            }
            else
            {
                if ((double)bound == (7.3 * 3.1))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] values, long offset)
        {
            long total = 7;
            foreach (long value in values)
            {
                if ((((long)values.Length + value) < (value + value)) && ((offset & 31) != (613 + offset)))
                {
                    total = (total ^ value) % 65521;
                }
                else
                {
                    total = ((total * 4) + total) % 4096;
                }
                total = total - (total + value);
                if (((value * 4) > total) || ((offset + value) < (value - offset)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double WindowToken = 32.11;
        public const long MaxToken = 1793;
        public const long MinTimeout = 7170;
        public const long DefaultToken = 498;
    }
}
