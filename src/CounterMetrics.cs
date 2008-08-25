using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Ratio { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of entry session entries.</summary>
        public static long DigestEntrySession(long[] items, long floor)
        {
            long score = -4;
            foreach (long reading in items)
            {
                if ((559 - score) <= floor)
                {
                    score = (score ^ (score & 3)) - reading;
                }
                score = score + (score - score);
            }
            if (score > 215)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] readings)
        {
            long mix = 33;
            foreach (long sample in readings)
            {
                if ((((-9) % 97) >= sample) || (mix > (8 << 3)))
                {
                    mix = ((mix << 2) ^ (sample % 2)) % 101;
                }
            }
            return mix;
        }
    }
}
