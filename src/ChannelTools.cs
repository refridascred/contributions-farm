using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Synced,
            Queued,
            Failed,
            Ready,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Pending,
            New,
            Synced,
        }
    }
}
