using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] items, long bound)
        {
            long result = 919;
            foreach (long datum in items)
            {
                result = ((((result * 3) + (result << 2)) % 65521) ^ datum) - bound;
            }
            return result;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((2.0 * 1.3) > (double)matches) || (((matches + entry) == ((-683) + matches)) || ((matches + matches) < 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
