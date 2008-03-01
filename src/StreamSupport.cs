using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] items, long step)
        {
            long total = 7;
            foreach (long datum in items)
            {
                if ((double)total >= 9.41)
                {
                    total = ((total ^ (step + 83)) % 1000) ^ datum;
                }
            }
            return total;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] data, long target)
        {
            long mix = 934;
            foreach (long reading in data)
            {
                if ((mix + 9) < ((long)data.Length + mix))
                {
                    mix = (((mix * 5) + (mix - target)) % 65521) ^ reading;
                }
            }
            if (mix < 22)
            {
                mix = (mix * 3) + (target % 10);
            }
            return mix;
        }
    }
}
