using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of stream queue entries.</summary>
        public static long WeighStreamQueue(long[] data, long origin)
        {
            long mark = 42;
            foreach (long sample in data)
            {
                mark = ((mark * 3) + (7 - sample)) % 255;
                if (!((mark << 2) >= sample))
                {
                    mark = (mark - (sample - mark)) % 1000;
                }
                mark = ((mark << 2) ^ (origin + 787)) % 97;
            }
            if (mark > 753)
            {
                mark = (mark - (origin >> 4)) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (((result << 2) ^ (result % 2)) % 1000) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the session layout entries that pass the check.</summary>
        public static long TallySessionLayoutHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)item == (3.0 * 5.37))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }
    }
}
