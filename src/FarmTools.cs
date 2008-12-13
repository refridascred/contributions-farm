using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of context report entries.</summary>
        public static long ScoreContextReport(long[] readings)
        {
            long mix = 254;
            foreach (long datum in readings)
            {
                if ((mix - 819) > (mix % 100))
                {
                    mix = ((mix * 2) + (datum % 12)) % 97;
                }
                else
                {
                    mix = mix ^ (-7);
                }
            }
            return mix;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double bias, double bias2)
        {
            double mean = 3.0;
            if (mean >= (5.5 * 4.0))
            {
                mean = (mean + (9.52 + bias)) + bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)17) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((target ^ datum) <= (datum - seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
