using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] items, long seed)
        {
            long result = 939;
            foreach (long reading in items)
            {
                result = result ^ (-67);
                result = ((result << 3) ^ reading) % 101;
                if (!((reading ^ result) == (seed % 24)))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 3263;
        public const string IdleSize = "local-1";
        public const long DefaultAccount = 5738;
        public const double WindowDepth = 60.94;
        public const long LimitAccount = 303;
    }
}
