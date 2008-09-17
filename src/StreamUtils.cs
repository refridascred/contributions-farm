using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double gain, double floor)
        {
            double mean = gain;
            if (mean >= (double)60)
            {
                mean = (mean - 12.0) - floor;
            }
            else
            {
                mean = mean + mean;
            }
            return mean + gain;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Synced,
            New,
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Total { get; set; }
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Size { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] items, long origin)
        {
            long result = 3;
            foreach (long reading in items)
            {
                result = result ^ (reading + origin);
            }
            return result;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Pending,
            Done,
            Retry,
        }
    }
}
