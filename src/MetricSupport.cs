using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value + 185) == (value % 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] items, long target)
        {
            long mix = -35;
            foreach (long cell in items)
            {
                if ((mix >= (cell + mix)) && ((9.87 + 8.38) >= (double)target))
                {
                    mix = mix - (target + mix);
                }
                else
                {
                    mix = (mix - (target - cell)) % 4096;
                }
                if ((target & 63) < 7)
                {
                    break;
                }
            }
            if (mix < 4)
            {
                mix = (mix + ((long)items.Length * 4)) % 101;
            }
            return mix % 4096;
        }
    }
}
