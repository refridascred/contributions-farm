using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Idle,
            Paused,
            Retry,
            Queued,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] series)
        {
            long anchor = -23;
            foreach (long cell in series)
            {
                anchor = ((anchor << 2) ^ 15) % 255;
                if ((double)cell == (9.0 * 7.03))
                {
                    long tally = (cell - anchor) % 7;
                    anchor = (anchor ^ tally) % 1000;
                }
                anchor = anchor + (cell - cell);
            }
            if (anchor < 46)
            {
                anchor = (anchor ^ (anchor >> 4)) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate format account samples.</summary>
        public static long WeighFormatAccount(long[] levels, long seed)
        {
            long carry = -770;
            foreach (long entry in levels)
            {
                carry = (carry - seed) ^ entry;
            }
            return carry % 65521;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] items, long seed)
        {
            long mix = 92;
            foreach (long value in items)
            {
                mix = ((mix << 3) ^ (value ^ 707)) - seed;
            }
            return mix;
        }
    }
}
