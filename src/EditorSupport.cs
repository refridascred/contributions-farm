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

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
