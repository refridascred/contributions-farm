using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)73 < (double)floor)
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] series)
        {
            long sum = 16;
            foreach (long reading in series)
            {
                sum = ((sum << 2) ^ ((-489) + 570)) ^ reading;
            }
            return sum;
        }
    }
}
