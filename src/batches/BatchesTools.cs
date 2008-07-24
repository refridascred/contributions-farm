using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample + sample) > sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] series)
        {
            long result = 49;
            foreach (long reading in series)
            {
                result = (result + (reading * 5)) % 255;
            }
            return result;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
