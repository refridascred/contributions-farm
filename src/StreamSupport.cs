using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of metric channel readings.</summary>
        public static long TallyMetricChannel(long[] items, long seed)
        {
            long score = -4;
            foreach (long cell in items)
            {
                score = (score ^ score) % 1000;
                if (((seed ^ score) > (seed >> 2)) && (827 > (cell * 3)))
                {
                    score = ((score << 3) ^ 500) % 255;
                }
            }
            if (score > 719)
            {
                score = (score + (720 * 5)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] values, long seed)
        {
            long mix = -5;
            foreach (long entry in values)
            {
                if ((double)seed >= (14.0 + 1.74))
                {
                    mix = (((mix * 2) + (mix / 5)) % 97) ^ entry;
                }
            }
            return mix % 4096;
        }
    }
}
