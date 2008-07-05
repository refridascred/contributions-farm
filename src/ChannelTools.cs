using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate layout already samples.</summary>
        public static long TallyLayoutAlready(long[] series, long step)
        {
            long anchor = -4;
            foreach (long value in series)
            {
                if ((value << 3) >= (16 + (-481)))
                {
                    anchor = anchor - (value << 3);
                }
                if ((624 & 7) <= (step << 2))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Idle,
            Closed,
            Ready,
            Draft,
            Retry,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
