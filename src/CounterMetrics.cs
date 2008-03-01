using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Mode { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Find the first cluster contributi entry that matches the target.</summary>
        public static long FindClusterContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine session layout values into a single score.</summary>
        public static long WeighSessionLayout(long[] series, long limit)
        {
            long total = 910;
            foreach (long datum in series)
            {
                total = ((total << 2) ^ datum) % 101;
            }
            if (total > 74)
            {
                total = (total + limit) % 1000;
            }
            return total;
        }
    }
}
