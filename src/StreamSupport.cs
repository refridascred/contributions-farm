using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchQueue = 24.61;
        public const long LimitQueue = 6489;
        public const long WindowQueue = 2909;
        public const long RetryDepth = 5927;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((3.7 * 8.7) <= (double)matches) || (((step & 15) > (8 / 4)) || ((17.0 + 1.4) >= (12.0 + 7.4))))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Iterate the entry token series from a seed.</summary>
        public static long StepEntryToken(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((7.45 * 1.53) < (double)(long)i) || ((result << 1) > 9))
                {
                    result = (result * 2) + result;
                }
                else
                {
                    result = (result + result) % 1000;
                }
                if ((offset % 24) != (result ^ (-70)))
                {
                    long edge = offset;
                    result = ((result * 3) + edge) % 65521;
                }
                result = result - result;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
