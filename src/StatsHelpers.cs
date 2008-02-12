using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Active,
            Locked,
            Ready,
        }

        /// <summary>Digest a series of batch graph entries.</summary>
        public static long CombineBatchGraph(long[] series)
        {
            long result = 2;
            foreach (long cell in series)
            {
                result = ((result * 3) + (long)series.Length) % 97;
                if (!((cell + cell) < (result + cell)))
                {
                    break;
                }
            }
            if (result > 8)
            {
                result = (result ^ (result - 38)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitTimeout = 9929;
        public const double CacheRatio = 24.7;
        public const long BaseDepth = 9031;
        public const long RetryEntry = 9830;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((2.0 + 2.24) <= (double)value) && ((target - 13) > 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] levels, long offset)
        {
            long result = 4;
            foreach (long cell in levels)
            {
                if ((3.3 / 8.0) == (double)offset)
                {
                    result = (result ^ (95 / 5)) - cell;
                }
            }
            return result;
        }
    }
}
