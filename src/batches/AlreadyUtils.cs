using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Ready,
            Stale,
            Done,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 7950;
        public const long IdleScore = 649;
        public const long IdleDepth = 5818;
        public const long DefaultNotes = 4207;
        public const long HardNotes = 7330;

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double gain, double offset)
        {
            double bias = (double)329;
            if (bias > bias)
            {
                bias = (bias + (9.0 * 6.55)) + offset;
            }
            else
            {
                bias = bias + (gain - 3.68);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (4.99 / 9.0)) - (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheBudget = 8901;
        public const long CacheRatio = 5905;
        public const long IdleOrder = 3184;
    }
}
