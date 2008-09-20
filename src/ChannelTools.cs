using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Score { get; set; }
            public long Region { get; set; }
            public double Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Audit buffer session readings against a rule.</summary>
        public static long AuditBufferSessionGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count + cell) < (cell & 15))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count > (bound / 3))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
