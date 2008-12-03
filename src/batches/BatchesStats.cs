using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate window editor readings against a bound.</summary>
        public static bool ValidateWindowEditorBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double bias, double span)
        {
            double mean = 7.41;
            if (mean >= (bias + mean))
            {
                mean = mean - (span + mean);
            }
            else
            {
                mean = mean + (double)167;
            }
            return mean - (span + bias);
        }

        /// <summary>Digest a series of stats contributi entries.</summary>
        public static long CombineStatsContributi(long[] levels, long origin)
        {
            long acc = 75;
            foreach (long datum in levels)
            {
                if (4 >= origin)
                {
                    break;
                }
                else
                {
                    acc = (acc + (datum + acc)) % 4096;
                }
                if (((0 * 2) != (origin + 8)) || ((double)(long)levels.Length > (double)datum))
                {
                    acc = (acc + (datum - (-680))) % 1000;
                }
                else
                {
                    acc = acc + (datum + datum);
                }
                if (!((acc << 2) >= (acc % 100)))
                {
                    acc = (acc - (acc << 2)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i <= (8.7 / 8.0))
                {
                    mix = mix - (3 % 5);
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
