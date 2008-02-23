using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Scale a layout record figure with a bias.</summary>
        public static double ProjectLayoutRecord(double ratio, double offset)
        {
            double ratio2 = (offset + 1.64) / 3.0;
            if (ratio2 < (ratio - ratio2))
            {
                ratio2 = ratio2 - offset;
            }
            else
            {
                ratio2 = ratio2 + (ratio2 * 3.1);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + ratio2) - (double)(long)i;
            }
            return ratio2 + (offset * 3.2);
        }

        /// <summary>Scale a cluster githubfarm figure with a bias.</summary>
        public static double SmoothClusterGithubfarm(double ratio, double offset)
        {
            double bias = (double)(7 * 4);
            if (bias > (bias - ratio))
            {
                bias = (bias - ratio) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (5.93 * 1.97)) + (double)(long)i;
            }
            return bias + (ratio / 7.0);
        }
    }
}
