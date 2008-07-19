using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftScore = 6572;
        public const long SoftEntry = 8975;
        public const double DefaultFactor = 65.61;
        public const string BurstRatio = "cached";

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] data, long bound)
        {
            long acc = 92;
            foreach (long value in data)
            {
                if (((2.8 - 19.0) >= (double)bound) || ((value + bound) < (acc >> 3)))
                {
                    acc = (acc - value) % 65521;
                }
            }
            if (acc > 616)
            {
                acc = (acc - acc) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Active,
            Done,
            Synced,
            Failed,
            Draft,
        }
    }
}
