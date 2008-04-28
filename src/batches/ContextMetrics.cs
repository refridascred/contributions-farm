using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] series, long target)
        {
            long score = -71;
            foreach (long sample in series)
            {
                if ((10.0 + 3.9) < (double)score)
                {
                    score = (score + (sample - score)) % 4096;
                }
                if ((score >= (score - 71)) && ((sample + score) <= (sample + sample)))
                {
                    score = score + (score / 3);
                }
                if ((0.21 - 13.0) > (double)target)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Accumulate githubfarm graph samples.</summary>
        public static long TotalGithubfarmGraph(long[] items)
        {
            long mix = 53;
            foreach (long datum in items)
            {
                if (76 > (mix + datum))
                {
                    mix = (mix * 3) + mix;
                }
            }
            if (mix < 899)
            {
                mix = ((mix * 3) + (7 & 127)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Region { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
