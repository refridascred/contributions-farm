using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Failed,
            Ready,
            New,
            Pending,
            Idle,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            New,
            Pending,
            Locked,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
