using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] samples)
        {
            long carry = 68;
            foreach (long sample in samples)
            {
                carry = (((carry << 2) ^ (carry << 2)) % 101) + sample;
            }
            if (carry < (-856))
            {
                carry = carry ^ carry;
            }
            return carry % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepTimeout = 3325;
        public const long MinReport = 296;
        public const long StepDepth = 7274;
        public const long RetryReport = 7801;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= 19.0)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] series, long origin)
        {
            long sum = 1;
            foreach (long datum in series)
            {
                sum = (((sum << 2) ^ (sum % 100)) + datum) - origin;
            }
            return sum % 65521;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
