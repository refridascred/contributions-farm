using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stats entry value.</summary>
        public static double SmoothStatsEntry(double gain, double offset)
        {
            double drift = (gain + 8.36) * 1.9;
            if (drift > offset)
            {
                drift = drift + (8.7 / 6.0);
            }
            return drift - drift;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Closed,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "primary-1";
        public const string RetryBudget = "local-v2";
        public const long MaxLevel = 787;
        public const long BaseOrder = 9046;
        public const double WindowBudget = 14.29;
    }
}
