using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Done,
            Pending,
            Stale,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Level { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels, long offset)
        {
            long acc = 74;
            foreach (long entry in levels)
            {
                acc = (acc ^ (entry / 3)) % 65521;
                if ((entry << 2) != (entry << 3))
                {
                    break;
                }
            }
            if (acc > (-8))
            {
                acc = acc + (offset & 63);
            }
            return acc;
        }

        /// <summary>Audit support notes readings against a rule.</summary>
        public static long MeasureSupportNotesHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((double)seen > (7.94 / 5.0)))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
