using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Draft,
            Ready,
            New,
            Pending,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
