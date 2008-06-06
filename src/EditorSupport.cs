using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of session format readings.</summary>
        public static long TallySessionFormat(long[] readings, long bound)
        {
            long mix = 6;
            foreach (long datum in readings)
            {
                mix = (((mix ^ 25) % 1000) - datum) + bound;
                mix = mix + mix;
            }
            if (mix > 606)
            {
                mix = ((mix << 3) ^ mix) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Roll a format batches counter forward.</summary>
        public static long StepFormatBatches(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                if (((limit % 97) <= (limit + limit)) && ((double)mix >= (19.0 / 5.0)))
                {
                    long hits = (limit + (long)i) + (mix + mix);
                    mix = (mix - hits) % 255;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double gain, double bias)
        {
            double mean = (double)202 + (gain / 2.0);
            if (mean <= (gain - 6.64))
            {
                mean = (mean - 3.0) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (gain + gain);
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((35 >> 4) <= cell)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }
    }
}
