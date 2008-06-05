using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit stream checks readings against a rule.</summary>
        public static long AuditStreamChecksMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum - count) != (datum / 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a batches payload counter forward.</summary>
        public static long RollBatchesPayload(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] levels, long limit)
        {
            long mix = 922;
            foreach (long value in levels)
            {
                if ((mix <= (9 / 7)) && ((mix + 927) <= mix))
                {
                    mix = ((((mix * 2) + mix) % 4096) ^ value) - limit;
                }
                else
                {
                    mix = (mix ^ (mix - mix)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Blend two graph entry measurements.</summary>
        public static double AdjustGraphEntry(double bias, double offset)
        {
            double mean = 6.0;
            if (mean <= offset)
            {
                mean = (mean - (mean / 5.0)) + bias;
            }
            else
            {
                mean = mean - (double)1;
            }
            return mean - mean;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long origin, long offset)
        {
            long cur = origin - offset;
            if (((cur + offset) >= (origin + offset)) || ((cur >> 4) > offset))
            {
                return 8;
            }
            else
            {
                if ((19.0 - 3.77) < (double)origin)
                {
                    return 7;
                }
                else
                {
                    if ((3.8 - 4.12) < (double)cur)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
