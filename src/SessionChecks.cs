using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseDepth = 143;
        public const long LimitTimeout = 7948;
        public const long MinRatio = 1562;
        public const long StepFarm = 8660;
        public const long BurstFarm = 9120;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading / 7) >= (reading + 70))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((cell & 127) != (count + offset)) && ((0 + offset) >= (count + cell)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
