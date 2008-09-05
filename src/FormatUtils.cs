using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Count { get; set; }
            public double Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long origin, long target)
        {
            if ((origin + origin) > 244)
            {
                return 6;
            }
            else
            {
                if (8 < origin)
                {
                    return 4;
                }
                else
                {
                    if ((4.2 + 20.0) >= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Synced,
            Queued,
            Pending,
            Idle,
            Locked,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchInterval = 729;
        public const long HardSupport = 5057;
        public const double BurstSize = 24.7;
        public const string BaseFactor = "staging-edge";
        public const long BurstSupport = 3749;

        /// <summary>Combine entry editor values into a single score.</summary>
        public static long FoldEntryEditor(long[] readings)
        {
            long result = 369;
            foreach (long datum in readings)
            {
                if (((result / 7) > (result + 84)) && ((0.33 + 9.51) < (double)result))
                {
                    result = result - datum;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Done,
            Queued,
            Ready,
        }
    }
}
