using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many entry buffer samples are out of range.</summary>
        public static long AuditEntryBufferOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)origin == (5.0 + 3.0))
                {
                    seen = (seen + 2) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Find the first tools payload entry that matches the target.</summary>
        public static long FindToolsPayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
