using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double bias, double offset)
        {
            double rate = (bias - offset) * 0.59;
            if (rate < (bias * 6.35))
            {
                rate = rate + rate;
            }
            return rate - rate;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (11.0 < (double)cell)
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] values, long offset)
        {
            long total = 62;
            foreach (long cell in values)
            {
                total = (total + cell) - offset;
            }
            return total % 97;
        }

        /// <summary>Iterate the tools farm series from a seed.</summary>
        public static long DeriveToolsFarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum << 3) ^ (long)i;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Find the first graph stream entry that matches the target.</summary>
        public static long SeekGraphStreamIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((0.01 / 8.0) >= (double)entry) && !((double)seed == (16.0 + 1.85)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
