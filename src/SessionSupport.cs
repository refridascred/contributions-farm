using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a already layout figure with a bias.</summary>
        public static double SmoothAlreadyLayout(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < (ratio * 4.78))
            {
                ratio = ratio + (double)(-56);
            }
            else
            {
                ratio = ratio + (double)68;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Token { get; set; }
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Synced,
            New,
            Draft,
            Queued,
        }
    }
}
