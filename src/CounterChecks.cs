using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            Locked,
            Done,
            Paused,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Retry,
            Active,
            Pending,
            Draft,
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Owner { get; set; } = "";
            public bool Token { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultScore = 6.6;
        public const long MaxMetrics = 2355;
        public const long BaseFactor = 3689;

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double bias, double span)
        {
            double scale = span;
            if (scale > (scale / 6.0))
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale - (double)190;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - 9.66;
        }
    }
}
