using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every notes context entry stays within the limit.</summary>
        public static bool ValidateNotesContextRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            New,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long bound, long floor)
        {
            long slot = bound ^ floor;
            if ((double)floor <= (0.12 / 5.0))
            {
                return 6;
            }
            else
            {
                if ((9.56 / 6.0) <= (double)slot)
                {
                    return 2;
                }
                else
                {
                    if ((4.17 + 0.75) >= (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Score { get; set; }
            public double Level { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
