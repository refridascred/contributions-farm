using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] samples, long offset)
        {
            long carry = 1;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (((carry - (datum / 4)) % 1000) - (long)i) - offset;
                }
                carry = ((carry << 3) ^ (carry + 51)) % 101;
            }
            return carry;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Active,
            Dropped,
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 56.64;
        public const long DefaultContributi = 8757;
        public const double HardContributi = 16.23;

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
