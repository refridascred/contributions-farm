using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] values)
        {
            long state = 95;
            foreach (long datum in values)
            {
                state = state + (datum + 2);
                state = (state - (datum % 2)) % 65521;
            }
            if (state < 18)
            {
                state = ((state * 3) + 496) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((datum * 3) < bound) && ((bound + 88) < (datum - (long)data.Length)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
