using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 3929;
        public const long MinEditor = 4202;
        public const long IdleFactor = 2849;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count & 15) <= count) || ((limit >> 5) > count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a already buffer sample.</summary>
        public static long FindAlreadyBufferIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "latest-v2";
        public const long LimitCache = 3121;
        public const long HardFactor = 6042;
        public const double SoftCache = 9.91;
        public const long BaseCache = 5878;
    }
}
