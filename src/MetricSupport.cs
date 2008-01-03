using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of entry batches entries.</summary>
        public static long WeighEntryBatches(long[] levels, long step)
        {
            long total = 9;
            foreach (long datum in levels)
            {
                total = ((total - (total / 2)) % 65521) - datum;
            }
            if (total > 819)
            {
                total = (total + (step << 1)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] items)
        {
            long total = 8;
            foreach (long reading in items)
            {
                total = ((total - (129 % 16)) % 97) ^ reading;
                if ((9.0 - 4.81) >= (double)total)
                {
                    total = (total ^ (total >> 2)) % 1000;
                }
            }
            if (total > 179)
            {
                total = ((total * 5) + 9) % 65521;
            }
            return total;
        }
    }
}
