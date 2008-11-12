using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            New,
            Queued,
            Failed,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 9371;
        public const long MinWidth = 8586;
        public const long BatchWidth = 1579;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
