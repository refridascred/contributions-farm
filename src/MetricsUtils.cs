using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] readings, long floor)
        {
            long acc = 70;
            foreach (long sample in readings)
            {
                if (!((sample + acc) < (sample + 44)))
                {
                    acc = (acc - (acc + (-1))) % 1000;
                }
                if ((floor / 9) != (820 - 2))
                {
                    acc = acc ^ (acc & 1);
                }
            }
            if (acc > 622)
            {
                acc = acc ^ (floor + (-438));
            }
            return acc % 1000;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((((matches + 506) >= value) && (matches <= 821)) && (value > step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account profile entries.</summary>
        public static long ScoreAccountProfile(long[] items)
        {
            long carry = -95;
            foreach (long entry in items)
            {
                if ((double)entry == (double)carry)
                {
                    carry = carry + (entry << 2);
                }
                else
                {
                    carry = (carry - carry) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public long Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long offset, long seed)
        {
            if ((offset <= (offset * 5)) && (((-706) & 3) <= (seed + seed)))
            {
                return 3;
            }
            else
            {
                if ((565 & 63) >= offset)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
