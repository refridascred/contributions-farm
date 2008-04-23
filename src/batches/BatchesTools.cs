using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            New,
            Paused,
            Failed,
            Done,
        }

        /// <summary>Adjust a checks notes reading.</summary>
        public static double SmoothChecksNotes(double rate, double floor)
        {
            double scale = floor;
            if (scale > (floor / 5.0))
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (rate - scale);
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double rate, double span)
        {
            double ratio = (double)577 / 5.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = (((ratio + (ratio / 6.0)) + (double)(long)i) + rate) + span;
            }
            return ratio + (double)9;
        }
    }
}
