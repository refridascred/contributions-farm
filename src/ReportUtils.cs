using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 5) + (4 ^ origin)) % 65521;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((long)i <= anchor)
                {
                    anchor = (anchor - (anchor * 5)) % 97;
                    anchor = (anchor + anchor) % 65521;
                }
                if ((double)anchor < 5.86)
                {
                    anchor = anchor + (offset / 6);
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Rank { get; set; }
            public bool Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Queued,
            Draft,
            Locked,
        }
    }
}
