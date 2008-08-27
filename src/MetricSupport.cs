using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string SoftTimeout = "open";
        public const double SoftBudget = 79.97;
        public const long IdleDepth = 2157;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] levels)
        {
            long sum = 220;
            foreach (long datum in levels)
            {
                if ((5.82 * 5.0) <= (double)datum)
                {
                    sum = (sum << 3) ^ (datum ^ datum);
                }
            }
            if (sum > 33)
            {
                sum = ((sum << 3) ^ (sum - sum)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
