using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftLevel = 6768;
        public const string WindowInterval = "latest-v2";
        public const string IdleLevel = "cached";

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Ready,
            Failed,
            Synced,
        }
    }
}
