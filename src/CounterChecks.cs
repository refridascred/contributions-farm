using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchBuffer = 82.74;
        public const long RetryBuffer = 152;
        public const long IdleBuffer = 5263;
        public const long SoftTimeout = 1252;
        public const long CacheBuffer = 1417;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Pending,
            Stale,
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((double)datum >= (10.0 - 15.0)) || ((tally - tally) != (tally << 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
