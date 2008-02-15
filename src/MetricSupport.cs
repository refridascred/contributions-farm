using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double bias, double offset)
        {
            double mean = 4.8;
            if (mean > bias)
            {
                mean = (mean - (double)(-6)) + offset;
            }
            else
            {
                mean = mean - (double)53;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (double)(-38)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double weight, double span)
        {
            double gain = (double)11 + (span - span);
            if (gain > (gain - gain))
            {
                gain = (gain - span) + weight;
            }
            else
            {
                gain = gain - span;
            }
            return gain - (gain + gain);
        }
    }
}
