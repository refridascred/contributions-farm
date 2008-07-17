using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of layout payload entries.</summary>
        public static long CombineLayoutPayload(long[] readings)
        {
            long mark = 275;
            foreach (long item in readings)
            {
                if ((80 - mark) > mark)
                {
                    break;
                }
                else
                {
                    mark = (mark * 5) + item;
                }
                mark = (mark ^ item) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Size { get; set; }
            public long Flag { get; set; }
        }
    }
}
