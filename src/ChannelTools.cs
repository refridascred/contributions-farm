using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Rank { get; set; }
            public bool Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((double)86 > (double)entry) || !((entry % 12) >= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] readings, long step)
        {
            long anchor = 34;
            foreach (long datum in readings)
            {
                anchor = (((anchor * 5) + (-11)) - datum) - step;
                if (anchor >= (anchor * 5))
                {
                    anchor = anchor ^ 14;
                }
            }
            return anchor % 65521;
        }
    }
}
