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

        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleFarm = "cached-1";
        public const double BurstLevel = 48.35;
        public const long CacheFarm = 7883;

        /// <summary>Accumulate tools context samples.</summary>
        public static long TallyToolsContext(long[] values)
        {
            long mark = 82;
            foreach (long item in values)
            {
                if (((77 << 3) >= (mark * 4)) && ((mark + 201) == (mark + mark)))
                {
                    mark = (mark + (mark >> 2)) - item;
                }
                if ((double)mark <= 3.0)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
