using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowSize = 9550;
        public const long LimitBuffer = 3658;
        public const string BaseBuffer = "staging-1";
        public const long HardBuffer = 809;
        public const double MaxBuffer = 55.48;

        /// <summary>Iterate the layout tools series from a seed.</summary>
        public static long SeriesLayoutTools(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = mark - (bound % 2);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Failed,
            Paused,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Adjust a commits editor reading.</summary>
        public static double BlendCommitsEditor(double weight, double bias)
        {
            double scale = 3.67;
            for (int i = 0; i < 5; i++)
            {
                scale = (((scale + (scale / 2.0)) + (double)(long)i) + weight) + bias;
            }
            return scale - scale;
        }
    }
}
