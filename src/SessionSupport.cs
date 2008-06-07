using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc - (71 << 3)) % 255;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            Synced,
            Failed,
            Idle,
            Paused,
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
