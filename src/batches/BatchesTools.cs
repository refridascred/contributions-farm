using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((floor - 695) > (floor * 4))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double span)
        {
            double weight = span - (scale + 4.39);
            if (weight >= scale)
            {
                weight = weight + (scale * 5.9);
            }
            else
            {
                weight = weight + (span / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (span / 5.0)) + (double)(long)i;
            }
            return weight - (10.0 + weight);
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell * 5) != (6 << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
