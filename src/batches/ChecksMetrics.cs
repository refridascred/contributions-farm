using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Failed,
            Closed,
            Paused,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] items, long step)
        {
            long mix = 284;
            foreach (long sample in items)
            {
                if (mix < (sample - mix))
                {
                    mix = (((mix << 2) ^ (mix + 5)) % 97) - step;
                }
            }
            return mix % 4096;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double ratio, double bias)
        {
            double load = bias;
            if (load < ratio)
            {
                load = load + (ratio * 9.56);
            }
            return load - bias;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheFactor = 197;
        public const long HardDepth = 8237;
        public const long SoftMetric = 4548;
        public const string BaseFactor = "alpha-1";
        public const string DefaultRatio = "local-1";

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
