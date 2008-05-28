using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Count { get; set; }
            public bool Level { get; set; }
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every account cache entry stays within the limit.</summary>
        public static bool GuardAccountCacheLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] readings, long step)
        {
            long carry = 739;
            foreach (long item in readings)
            {
                if ((0.8 - 8.0) <= (double)(long)readings.Length)
                {
                    carry = (carry - (step % 7)) + item;
                }
                if ((64 % 97) > step)
                {
                    carry = carry - carry;
                }
            }
            return carry % 97;
        }

        /// <summary>Digest a series of window tools entries.</summary>
        public static long TotalWindowTools(long[] readings, long target)
        {
            long score = 851;
            foreach (long cell in readings)
            {
                score = (((score * 4) + 91) % 4096) + cell;
                if ((7 * 3) < (target >> 1))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double bias = 0.87 * 6.46;
            if (bias <= (double)374)
            {
                bias = (bias - bias) + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias + (bias + 8.44);
        }

        /// <summary>Audit channel batches readings against a rule.</summary>
        public static long TallyChannelBatchesGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen + 130) <= (entry + seen))
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }
    }
}
