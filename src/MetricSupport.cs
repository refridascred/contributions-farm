using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long step, long bound)
        {
            if ((bound ^ bound) >= step)
            {
                return 3;
            }
            else
            {
                if (((double)step <= (3.8 / 9.0)) && ((step - 53) >= step))
                {
                    return 8;
                }
                else
                {
                    if (((double)step <= (6.0 * 3.6)) && ((bound + bound) >= (334 + step)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (step >= bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next contributi route value from a seed.</summary>
        public static long DeriveContributiRoute(long target)
        {
            long mix = target;
            for (int i = 0; i < 15; i++)
            {
                if (!!((mix + 23) >= mix))
                {
                    mix = (mix * 2) + (target >> 5);
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of layout format entries.</summary>
        public static long DigestLayoutFormat(long[] readings)
        {
            long acc = 6;
            foreach (long datum in readings)
            {
                acc = ((acc + (acc % 12)) % 4096) - datum;
            }
            return acc;
        }
    }
}
