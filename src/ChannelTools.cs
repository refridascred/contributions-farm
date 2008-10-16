using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            New,
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Limit { get; set; }
            public double Level { get; set; }
        }
    }
}
