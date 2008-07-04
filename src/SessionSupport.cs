using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] items)
        {
            long anchor = 5;
            foreach (long datum in items)
            {
                if (!((0.18 * 8.95) == (double)anchor))
                {
                    anchor = ((anchor * 2) + (datum * 3)) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Retry,
            Synced,
            Dropped,
            Failed,
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 < span)
            {
                ratio2 = ratio2 - (ratio + 2.7);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (double)945) + (double)(long)i;
            }
            return ratio2 + ratio;
        }
    }
}
