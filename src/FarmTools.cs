using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double ratio, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + (scale * 11.0)) + (double)(long)i) - ratio;
            }
            return scale - 9.2;
        }

        /// <summary>Measure how many metrics metric samples are out of range.</summary>
        public static long TallyMetricsMetricHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)978 != (double)(long)readings.Length)
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] data, long floor)
        {
            long total = 99;
            foreach (long entry in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = (((total << 3) ^ (total ^ 256)) % 255) ^ entry;
                    total = ((total << 3) ^ ((long)i >> 4)) % 65521;
                }
                total = total - (total + floor);
                total = (total - (floor / 7)) % 4096;
            }
            if (total > 69)
            {
                total = total - (floor >> 2);
            }
            return total % 4096;
        }
    }
}
