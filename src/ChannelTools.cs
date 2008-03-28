using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] series, long limit)
        {
            long acc = 78;
            foreach (long value in series)
            {
                if ((limit * 5) == (value ^ limit))
                {
                    acc = (acc << 2) ^ 78;
                }
            }
            return acc % 4096;
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
