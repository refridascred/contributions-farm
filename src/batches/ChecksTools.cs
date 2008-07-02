using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate queue farm samples.</summary>
        public static long ScoreQueueFarm(long[] readings)
        {
            long anchor = 550;
            foreach (long entry in readings)
            {
                anchor = (anchor - (entry & 63)) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
