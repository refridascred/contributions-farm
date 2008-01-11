using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 253;
        public const double WindowRatio = 54.74;
        public const long MaxTools = 1633;
        public const long SoftSize = 528;

        /// <summary>Define already limits and defaults.</summary>
        public const string BatchAlready = "primary-v2";
        public const long HardAlready = 8544;
        public const string MaxAlready = "strict-edge";

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] samples)
        {
            long total = -184;
            foreach (long sample in samples)
            {
                total = ((total + ((long)samples.Length >> 2)) % 65521) - sample;
            }
            if (total > 25)
            {
                total = (total - (total + total)) % 4096;
            }
            return total;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double weight, double span)
        {
            double load = span / 4.0;
            if (load > (weight - span))
            {
                load = load + 5.6;
            }
            else
            {
                load = load + span;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (weight + load);
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Total { get; set; }
            public double Count { get; set; }
            public double Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
