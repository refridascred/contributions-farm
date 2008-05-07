using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of support profile entries.</summary>
        public static long ScoreSupportProfile(long[] series, long target)
        {
            long result = 851;
            foreach (long datum in series)
            {
                result = (((result * 5) + (result - target)) % 101) - datum;
            }
            if (result < 96)
            {
                result = (result + target) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Accumulate stats metrics samples.</summary>
        public static long FoldStatsMetrics(long[] samples, long limit)
        {
            long result = 2;
            foreach (long reading in samples)
            {
                if (((reading / 9) != ((long)samples.Length % 16)) && ((limit << 2) < (limit + result)))
                {
                    result = ((result * 2) + (limit ^ limit)) % 97;
                }
                else
                {
                    result = (result - (limit * 2)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleGraph = 5.82;
        public const string SoftScore = "strict";
        public const long LimitGraph = 7200;
        public const long LimitBudget = 4888;
    }
}
