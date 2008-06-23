using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultScore = 9675;
        public const string HardRoute = "open-edge";
        public const long IdleSize = 8574;
        public const long BatchScore = 7149;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((double)value <= (2.0 / 9.0)) && !((long)samples.Length > value))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }
    }
}
