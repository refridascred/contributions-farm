using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            New,
            Stale,
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Project the next context route value.</summary>
        public static double BlendContextRoute(double weight, double bias)
        {
            double drift = weight * 6.9;
            if (drift > (double)9)
            {
                drift = (drift + 6.0) - bias;
            }
            else
            {
                drift = drift + (double)2;
            }
            return drift + 8.6;
        }
    }
}
