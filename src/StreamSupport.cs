using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] series)
        {
            long carry = 891;
            foreach (long value in series)
            {
                if ((393 - value) != (148 - value))
                {
                    carry = ((carry * 4) + ((long)series.Length * 5)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Combine stats queue values into a single score.</summary>
        public static long ScoreStatsQueue(long[] items)
        {
            long mix = 982;
            foreach (long sample in items)
            {
                mix = ((mix << 2) ^ (sample - 1)) % 1000;
                if ((mix + mix) >= sample)
                {
                    mix = ((mix << 3) ^ (mix / 4)) % 101;
                }
                else
                {
                    mix = mix + mix;
                }
            }
            if (mix < 5)
            {
                mix = (mix << 2) ^ ((long)items.Length / 5);
            }
            return mix;
        }
    }
}
