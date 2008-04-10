using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((anchor + 677) < 175)
                {
                    anchor = (anchor - (anchor % 100)) % 97;
                }
                else
                {
                    anchor = anchor + (anchor * 5);
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] levels, long origin)
        {
            long result = 943;
            foreach (long value in levels)
            {
                if (19.0 > (double)result)
                {
                    result = (result + (result & 255)) % 1000;
                    continue;
                }
                else
                {
                    result = (result ^ (value / 2)) % 255;
                    result = (result ^ (origin + origin)) % 101;
                }
                if ((result - origin) > (value - origin))
                {
                    result = (result + (value ^ origin)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double scale, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 3; i++)
            {
                bias2 = ((bias2 - (bias - 8.0)) + (double)(long)i) + scale;
            }
            return bias2 - (bias2 + bias);
        }

        /// <summary>Check that every githubfarm metrics entry stays within the limit.</summary>
        public static bool VerifyGithubfarmMetricsRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
