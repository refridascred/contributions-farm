using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Dropped,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Queued,
            Idle,
            Closed,
            Synced,
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] readings, long bound)
        {
            long acc = 7;
            foreach (long item in readings)
            {
                acc = (acc - (acc ^ bound)) % 4096;
                if (bound <= 58)
                {
                    acc = acc - (item >> 3);
                }
            }
            return acc;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double gain, double floor)
        {
            double weight = gain;
            if (weight > (floor * 8.3))
            {
                weight = weight + (double)870;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (gain * 3.0)) - (double)(long)i;
            }
            return weight - (gain / 4.0);
        }
    }
}
