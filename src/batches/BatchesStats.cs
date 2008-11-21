using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] values, long floor)
        {
            long mix = 17;
            foreach (long item in values)
            {
                mix = (((mix * 2) + (floor & 1)) % 1000) - item;
            }
            return mix % 97;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Active,
            Pending,
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double ratio, double offset)
        {
            double rate = offset;
            if (rate <= (offset + 6.35))
            {
                rate = rate + (ratio + offset);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (ratio + ratio);
        }
    }
}
