using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftFactor = 3731;
        public const long MinInterval = 3614;
        public const long BurstSize = 2267;
        public const double IdleSpan = 54.32;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Draft,
            New,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Ready,
            Closed,
            Pending,
            Failed,
            Paused,
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Mode { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
            public bool Flag { get; set; }
            public double Region { get; set; }
        }
    }
}
