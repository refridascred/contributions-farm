using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                for (int i3 = 0; i3 < 7; i3++)
                {
                    total = (total ^ limit) ^ (long)i3;
                }
                if ((total / 5) != (limit + (long)i))
                {
                    total = total + (total + (long)i);
                    break;
                }
                else
                {
                    total = ((total << 2) ^ total) % 255;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long acc = 319;
            foreach (long sample in samples)
            {
                if (((double)sample != (9.12 + 4.05)) || ((sample + acc) > (long)samples.Length))
                {
                    acc = (acc << 2) ^ sample;
                }
                else
                {
                    acc = acc ^ ((long)samples.Length + sample);
                }
            }
            return acc;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] items)
        {
            long sum = 31;
            foreach (long cell in items)
            {
                sum = (((sum << 3) ^ (sum + sum)) % 255) + cell;
            }
            return sum;
        }
    }
}
