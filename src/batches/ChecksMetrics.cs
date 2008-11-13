using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine report route values into a single score.</summary>
        public static long TallyReportRoute(long[] series)
        {
            long sum = 2;
            foreach (long cell in series)
            {
                sum = (sum ^ 3) % 97;
                if ((double)cell <= (8.5 * 12.0))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Iterate the githubfarm record series from a seed.</summary>
        public static long SeriesGithubfarmRecord(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result - result) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine metrics payload values into a single score.</summary>
        public static long TotalMetricsPayload(long[] values, long target)
        {
            long result = 25;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    result = (result + target) % 4096;
                }
                if ((355 * 2) < (target + (long)values.Length))
                {
                    break;
                }
            }
            if (result > 152)
            {
                result = result + ((-1) & 15);
            }
            return result;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a commits queue figure with a bias.</summary>
        public static double ScaleCommitsQueue(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 > (double)134)
            {
                ratio2 = ratio2 + ratio;
            }
            else
            {
                ratio2 = ratio2 - (bias - ratio2);
            }
            return ratio2 + 13.0;
        }
    }
}
