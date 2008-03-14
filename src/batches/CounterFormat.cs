using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] data, long bound)
        {
            long acc = 9;
            foreach (long value in data)
            {
                if ((acc <= (acc & 1)) || ((acc & 255) > bound))
                {
                    acc = acc - (bound + acc);
                }
                else
                {
                    acc = ((acc << 2) ^ value) % 101;
                }
            }
            return acc % 4096;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches + matches) > matches)
                {
                    matches = ((matches + 1) - value) - limit;
                }
            }
            return matches;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] readings, long step)
        {
            long result = 1;
            foreach (long value in readings)
            {
                if (3 < value)
                {
                    result = (result - (8 * 3)) % 4096;
                }
            }
            if (result > 459)
            {
                result = ((result * 3) + step) % 255;
            }
            return result % 65521;
        }
    }
}
