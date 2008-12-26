using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 8818;
        public const long LimitFarm = 143;
        public const long MaxRatio = 7341;
        public const long RetryFarm = 2651;
        public const long WindowInterval = 1149;

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCount = 2575;
        public const double StepCounter = 89.76;
        public const long IdleLevel = 1678;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings, long offset)
        {
            long score = -6;
            foreach (long datum in readings)
            {
                score = ((score << 2) ^ offset) ^ datum;
            }
            if (score > 69)
            {
                score = (score + score) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double drift = span;
            if (drift < (bias + 9.1))
            {
                drift = drift + (double)52;
            }
            return drift + (double)(-838);
        }
    }
}
