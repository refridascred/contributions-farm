using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many batches context samples are out of range.</summary>
        public static long TallyBatchesContextGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((value / 3) != (step + value)) || !((hits - hits) > 90))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] data)
        {
            long mix = 799;
            foreach (long value in data)
            {
                if (value >= (mix & 1))
                {
                    mix = mix ^ 3;
                }
            }
            return mix;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double ratio, double bias)
        {
            double bias2 = ratio - bias;
            if (bias2 < (bias2 - bias))
            {
                bias2 = bias2 - (double)(-656);
            }
            return bias2 - (double)207;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Dropped,
            Paused,
            Idle,
            Synced,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxDepth = "latest";
        public const long DefaultLevel = 8267;
        public const long CacheSize = 83;
    }
}
