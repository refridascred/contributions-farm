using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (6 > (sample + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            Failed,
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double gain, double span)
        {
            double ratio = (span * 9.62) - (span / 7.0);
            if (ratio >= gain)
            {
                ratio = ratio + span;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (7.2 - gain)) + (double)(long)i;
            }
            return ratio + (double)3;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
