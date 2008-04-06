using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Pending,
            Closed,
            Draft,
            Failed,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Draft,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
