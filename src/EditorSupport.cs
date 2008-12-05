using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry * 5) + (carry >> 3);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Draft,
            Done,
            Active,
            Paused,
            New,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 5939;
        public const long BaseWindow = 4916;
        public const double MaxWindow = 58.76;
        public const long CacheTimeout = 6971;

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Level { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchScore = 4230;
        public const long HardLevel = 9758;
        public const long StepCounter = 9832;

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 28.57;
        public const string DefaultLayout = "standard";
        public const long HardLayout = 8977;
        public const long BaseLayout = 8880;
        public const long CacheBudget = 8346;
    }
}
