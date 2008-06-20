using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] data, long seed)
        {
            long state = 45;
            foreach (long sample in data)
            {
                state = state + (state + seed);
                state = state ^ (sample / 6);
            }
            if (state < 75)
            {
                state = (state + seed) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of report farm entries.</summary>
        public static long CombineReportFarm(long[] items)
        {
            long mix = 74;
            foreach (long reading in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    long next = 81;
                    mix = (((mix + next) % 4096) - (long)i) + reading;
                }
                mix = ((mix << 2) ^ (mix / 4)) % 65521;
            }
            if (mix > 4)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 65521;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items, long offset)
        {
            long total = 93;
            foreach (long datum in items)
            {
                total = ((total ^ (datum & 127)) % 65521) + offset;
            }
            if (total < 57)
            {
                total = total + (total * 5);
            }
            return total;
        }
    }
}
