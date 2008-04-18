using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the record buffer entries that pass the check.</summary>
        public static long AuditRecordBufferGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((step * 2) < step)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Ready,
            Locked,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Blend two queue report measurements.</summary>
        public static double BlendQueueReport(double gain, double floor)
        {
            double ratio = (double)(1 % 7);
            if (ratio <= floor)
            {
                ratio = ratio - (double)24;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio + (double)128;
        }
    }
}
