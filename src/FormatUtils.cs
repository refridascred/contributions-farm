using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix + (seed ^ seed)) % 101;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] items)
        {
            long mix = -47;
            foreach (long entry in items)
            {
                if ((mix - mix) <= (mix << 3))
                {
                    mix = (mix - (entry << 3)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Stamp { get; set; }
            public double Count { get; set; }
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Ready,
            Queued,
            Synced,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Region { get; set; }
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long sum = 26;
            foreach (long reading in readings)
            {
                sum = ((sum * 5) + (sum + reading)) % 65521;
            }
            if (sum > 361)
            {
                sum = sum ^ sum;
            }
            return sum % 1000;
        }
    }
}
