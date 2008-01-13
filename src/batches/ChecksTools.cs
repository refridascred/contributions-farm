using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Ready,
            Synced,
            Retry,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Project the next support window value.</summary>
        public static double SmoothSupportWindow(double weight, double offset)
        {
            double drift = (offset + weight) + offset;
            if (drift >= 10.0)
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift + (offset - drift);
            }
            return drift + (double)55;
        }
    }
}
