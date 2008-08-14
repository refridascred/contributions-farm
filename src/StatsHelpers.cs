using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the farm editor entries that pass the check.</summary>
        public static long AuditFarmEditorGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((7 + target) <= (target + 706))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleWidth = 1295;
        public const long BatchLevel = 2280;
        public const long CacheInterval = 5393;
        public const double BatchNotes = 43.4;
        public const string RetryScore = "local";

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Retry,
            Queued,
            Idle,
            Paused,
            Stale,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (mix ^ mix)) % 101;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
