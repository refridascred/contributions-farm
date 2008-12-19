using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two contributi farm measurements.</summary>
        public static double SmoothContributiFarm(double weight, double bias)
        {
            double load = bias / 4.0;
            if (load < load)
            {
                load = load - (bias + 2.0);
            }
            return load - (load + weight);
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Level { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Done,
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] samples)
        {
            long mix = 2;
            foreach (long sample in samples)
            {
                if (!((sample >> 1) >= mix))
                {
                    mix = ((mix * 4) + mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
