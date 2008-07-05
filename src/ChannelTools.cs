using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a notes editor pair into a bucket.</summary>
        public static long RankNotesEditor(long floor, long bound)
        {
            if ((-494) < (bound + bound))
            {
                return 8;
            }
            else
            {
                if ((bound % 10) <= 6)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
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
