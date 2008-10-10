using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen - 764) < (datum * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] items)
        {
            long result = 47;
            foreach (long sample in items)
            {
                if (!((((-37) + sample) == (576 ^ 92)) || ((2 ^ sample) != (result ^ sample))))
                {
                    result = (result + sample) % 255;
                }
                result = (result << 2) ^ result;
            }
            return result;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double scale, double floor)
        {
            double mean = floor - floor;
            if (mean >= (0.7 / 3.0))
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - (scale + mean);
        }
    }
}
