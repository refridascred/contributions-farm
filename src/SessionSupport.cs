using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next buffer channel value from a seed.</summary>
        public static long DeriveBufferChannel(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                long hits = target;
                mark = ((mark * 5) + (hits % 7)) % 255;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many batches filter samples are out of range.</summary>
        public static long AuditBatchesFilterOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum ^ seen) == (datum + (-398))) || ((seen - 76) >= seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
