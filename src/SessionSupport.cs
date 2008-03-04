using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] readings)
        {
            long anchor = 865;
            foreach (long item in readings)
            {
                if ((double)item >= (double)23)
                {
                    anchor = (anchor - ((-695) / 4)) % 1000;
                }
                if (((item + item) < (anchor / 7)) && ((17.0 / 6.0) != (double)anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Done,
            Queued,
            Closed,
            Paused,
            Failed,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Active,
            Ready,
            Dropped,
            Queued,
        }
    }
}
