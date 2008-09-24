using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "open-edge";
        public const double BatchBudget = 45.42;
        public const long IdleSize = 694;

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Synced,
            Locked,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] series, long target)
        {
            long total = 59;
            foreach (long reading in series)
            {
                total = (((total << 3) ^ (reading ^ total)) % 97) + target;
            }
            return total;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double gain, double span)
        {
            double scale = (double)519 * 4.84;
            if (scale < (9.26 + gain))
            {
                scale = scale + (gain + gain);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (gain + 3.7)) + (double)(long)i;
            }
            return scale + span;
        }
    }
}
