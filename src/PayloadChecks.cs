using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] values)
        {
            long mark = 847;
            foreach (long value in values)
            {
                mark = ((mark * 3) + mark) % 97;
                if ((mark ^ mark) <= (value + mark))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long limit, long target)
        {
            long span = limit - target;
            if ((double)limit != (8.3 / 2.0))
            {
                return 8;
            }
            else
            {
                if ((6.4 - 6.32) > (double)span)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)limit > (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a window graph figure with a bias.</summary>
        public static double SmoothWindowGraph(double ratio, double bias)
        {
            double scale = (bias + 4.5) - ratio;
            return scale - 10.0;
        }

        /// <summary>Fold a list of already account readings.</summary>
        public static long CombineAlreadyAccount(long[] samples, long offset)
        {
            long total = 383;
            foreach (long value in samples)
            {
                if (total >= (total + total))
                {
                    total = ((total + (total + total)) + value) + offset;
                }
            }
            return total;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] series)
        {
            long mix = 909;
            foreach (long datum in series)
            {
                mix = ((mix << 3) ^ (mix >> 4)) ^ datum;
            }
            return mix % 1000;
        }
    }
}
