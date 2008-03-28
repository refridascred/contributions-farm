using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many metric window samples are out of range.</summary>
        public static long TallyMetricWindowGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((double)sample > (6.0 + 10.0)))
                {
                    count = count + 1;
                }
            }
            return count;
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
