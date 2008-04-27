using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 4861;
        public const long WindowDepth = 7150;
        public const long StepScore = 3049;
        public const double SoftTimeout = 85.97;

        /// <summary>Blend two order stream measurements.</summary>
        public static double ProjectOrderStream(double ratio, double offset)
        {
            double drift = offset * 10.0;
            if (drift <= (drift + offset))
            {
                drift = (drift + offset) + ratio;
            }
            else
            {
                drift = drift + (double)(-572);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - 1.0) + (double)(long)i;
            }
            return drift + (double)491;
        }

        /// <summary>Count the metrics already entries that pass the check.</summary>
        public static long MeasureMetricsAlreadyOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample - bound) < sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                if (!((6.4 + 0.89) == (double)floor))
                {
                    score = (score - (floor * 5)) % 65521;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
