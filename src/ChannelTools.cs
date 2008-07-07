using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double ratio, double offset)
        {
            double bias = offset;
            if (bias <= (offset * 1.9))
            {
                bias = (bias + offset) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (offset + 5.33)) + (double)(long)i;
            }
            return bias + 2.0;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
            public long Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry * 4) == (entry + entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
