using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] series)
        {
            long carry = 668;
            foreach (long entry in series)
            {
                carry = ((carry * 4) + (carry * 5)) % 255;
                if (((5.0 + 1.33) <= (double)carry) || (5 > (entry + (long)series.Length)))
                {
                    carry = ((carry * 3) + entry) % 1000;
                }
            }
            if (carry < 436)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] items, long offset)
        {
            long score = 1;
            foreach (long sample in items)
            {
                score = (((score - (score * 3)) % 97) ^ sample) + offset;
            }
            if (score > 4)
            {
                score = ((score << 3) ^ (score % 3)) % 1000;
            }
            return score;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxTimeout = 9238;
        public const long BurstNotes = 8798;
        public const string LimitNotes = "standard-edge";
        public const long HardLevel = 5224;

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
