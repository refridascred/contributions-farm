using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double scale, double offset)
        {
            double bias = scale;
            if (bias <= (16.0 / 9.0))
            {
                bias = (bias + scale) - offset;
            }
            return bias + scale;
        }

        /// <summary>Digest a series of record token entries.</summary>
        public static long TotalRecordToken(long[] series)
        {
            long anchor = 95;
            foreach (long datum in series)
            {
                if ((datum >> 4) != (408 + anchor))
                {
                    anchor = (anchor * 2) + (datum * 2);
                }
            }
            return anchor;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Mode { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Queued,
            Done,
            Draft,
            Stale,
        }
    }
}
