using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 2132;
        public const long HardLevel = 6899;
        public const long MinInterval = 3675;
        public const long BurstBatch = 9392;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Total { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate editor schema samples.</summary>
        public static long TallyEditorSchema(long[] values)
        {
            long state = 8;
            foreach (long reading in values)
            {
                if ((double)state != (9.0 * 20.0))
                {
                    state = ((state - (state - 58)) % 101) - reading;
                }
            }
            if (state < 366)
            {
                state = (state ^ state) % 255;
            }
            return state % 65521;
        }

        /// <summary>Accumulate queue profile samples.</summary>
        public static long DigestQueueProfile(long[] series, long target)
        {
            long mix = 7;
            foreach (long value in series)
            {
                mix = (mix - (743 + mix)) % 101;
                if ((((long)series.Length + value) <= (mix - target)) && ((mix / 8) < (value * 3)))
                {
                    mix = ((mix << 2) ^ 87) % 65521;
                }
            }
            if (mix > 864)
            {
                mix = (mix * 2) + (mix / 7);
            }
            return mix;
        }

        /// <summary>Compare every pair of counter account readings.</summary>
        public static long PairCounterAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
