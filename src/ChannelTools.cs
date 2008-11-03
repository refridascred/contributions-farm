using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Dropped,
            Idle,
            Ready,
            Done,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate support session samples.</summary>
        public static long TallySupportSession(long[] items, long floor)
        {
            long result = 7;
            foreach (long datum in items)
            {
                if (!((double)datum != (7.0 - 5.3)))
                {
                    result = ((result << 2) ^ (datum << 3)) % 97;
                }
                else
                {
                    result = ((result << 3) ^ (floor & 3)) % 65521;
                }
            }
            return result % 97;
        }
    }
}
