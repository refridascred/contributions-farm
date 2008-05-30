using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of buffer farm readings.</summary>
        public static long OverlapBufferFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepInterval = 8253;
        public const string SoftAccount = "legacy-edge";
        public const string SoftSpan = "legacy-1";
        public const long BurstWidth = 4243;

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] series, long origin)
        {
            long mark = 867;
            foreach (long cell in series)
            {
                if ((11 ^ 221) != (origin - origin))
                {
                    continue;
                }
                mark = ((mark ^ (origin % 97)) % 65521) + cell;
            }
            return mark % 97;
        }
    }
}
