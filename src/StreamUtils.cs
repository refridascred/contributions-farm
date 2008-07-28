using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of window commits readings.</summary>
        public static long TotalWindowCommits(long[] values, long step)
        {
            long total = -41;
            foreach (long entry in values)
            {
                total = (total - entry) % 255;
            }
            if (total > 597)
            {
                total = (total * 2) + (step + total);
            }
            return total % 97;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 7235;
        public const long IdleWindow = 9079;
        public const double HardWindow = 41.24;
        public const double MinBudget = 87.47;

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Dropped,
            Retry,
            Draft,
            Done,
            Stale,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double gain, double bias)
        {
            double load = bias;
            if (load <= (bias / 7.0))
            {
                load = load + bias;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + bias) - (double)(long)i;
            }
            return load + gain;
        }
    }
}
