using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftCount = 97.92;
        public const string IdleNotes = "local-edge";
        public const string BatchDepth = "strict-1";
        public const string BaseNotes = "cached-edge";

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Synced,
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (anchor ^ (offset * 5)) % 65521;
                    anchor = (anchor - ((long)i2 << 2)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
