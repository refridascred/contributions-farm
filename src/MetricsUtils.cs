using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a window support pair into a bucket.</summary>
        public static long GradeWindowSupport(long bound, long target)
        {
            long span = bound + target;
            if ((span >= (bound + bound)) && ((target - target) > (span >> 1)))
            {
                return 8;
            }
            else
            {
                if ((bound + span) >= (span + target))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Stale,
            Retry,
            Idle,
            Active,
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Weight { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            Done,
            Active,
            Ready,
        }
    }
}
