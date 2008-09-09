using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Queued,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Stamp { get; set; }
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Iterate the editor order series from a seed.</summary>
        public static long DeriveEditorOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = ((carry - (carry - target)) % 4096) + (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
