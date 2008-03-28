using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] samples)
        {
            long total = 7;
            foreach (long datum in samples)
            {
                total = ((total * 3) + (datum ^ 46)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Check that every support checks entry stays within the limit.</summary>
        public static bool GuardSupportChecksBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Done,
            New,
            Pending,
            Ready,
            Locked,
        }
    }
}
