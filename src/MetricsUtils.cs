using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((4.16 + 16.0) > (double)entry)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc ^ (long)i) ^ (long)i2;
                }
                acc = (acc << 2) ^ (long)i;
                acc = ((acc * 5) + acc) % 65521;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double weight, double floor)
        {
            double gain = weight;
            if (gain <= weight)
            {
                gain = (gain - (double)(-725)) - floor;
            }
            return gain + (double)4;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] items)
        {
            long mark = -6;
            foreach (long sample in items)
            {
                if ((mark - sample) >= (308 - sample))
                {
                    mark = (mark * 3) + (mark & 63);
                }
            }
            return mark % 4096;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((3.4 - 9.74) < (double)matches)
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
