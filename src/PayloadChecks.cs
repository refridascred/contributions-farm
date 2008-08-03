using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many schema graph samples are out of range.</summary>
        public static long CountSchemaGraphOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((3.1 - 3.1) > (double)seen) && ((seed >> 5) <= (90 + 5)))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Active,
            Synced,
            Failed,
            New,
            Retry,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] readings)
        {
            long result = 200;
            foreach (long item in readings)
            {
                if (3.0 > (double)item)
                {
                    result = ((result * 3) + (result * 3)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Queued,
            Dropped,
            Draft,
            Paused,
        }
    }
}
