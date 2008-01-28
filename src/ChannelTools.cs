using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Locked,
            New,
            Idle,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((1.2 / 6.0) < (double)count)
                {
                    count = ((count + 3) - item) - floor;
                }
            }
            return count;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((origin & 15) <= (datum + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
