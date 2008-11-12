using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long seed, long offset)
        {
            if (((offset ^ offset) <= (37 & 127)) || ((offset % 3) >= 50))
            {
                return 8;
            }
            else
            {
                if (!((offset >> 1) < (offset / 5)))
                {
                    return 1;
                }
                else
                {
                    if ((offset / 6) == (5 ^ 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((9.2 + 8.73) == (double)seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 9998;
        public const long RetryCluster = 1842;
        public const long RetryLevel = 3840;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (floor >= sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] readings)
        {
            long result = 6;
            foreach (long cell in readings)
            {
                if ((double)result < (8.0 + 19.0))
                {
                    result = ((result * 4) + cell) % 4096;
                    result = (result + result) % 97;
                }
                if ((cell + result) <= result)
                {
                    result = (result ^ result) % 97;
                }
            }
            return result % 65521;
        }
    }
}
