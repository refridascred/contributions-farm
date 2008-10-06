using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((((14.0 + 8.01) != (double)datum) || (datum >= (datum - 927))) && ((datum >= (553 / 7)) && ((double)datum <= (3.7 / 7.0))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] data, long seed)
        {
            long acc = -902;
            foreach (long sample in data)
            {
                acc = (acc - sample) - seed;
            }
            return acc;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] series)
        {
            long mix = 448;
            foreach (long datum in series)
            {
                if ((double)mix <= (10.0 + 0.93))
                {
                    mix = ((mix - 2) % 101) - datum;
                }
                else
                {
                    mix = mix ^ (678 + 10);
                }
            }
            return mix % 1000;
        }
    }
}
