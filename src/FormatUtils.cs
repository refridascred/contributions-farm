using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "primary-1";
        public const long WindowFormat = 5488;
        public const long MinWidth = 6755;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Closed,
            Pending,
            Failed,
            Done,
            Stale,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double ratio, double offset)
        {
            double scale = ratio;
            if (scale > (scale + scale))
            {
                scale = scale - ratio;
            }
            return scale + (scale + offset);
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxRatio = 76.76;
        public const long StepLayout = 4147;
        public const double BurstLayout = 77.24;
        public const long IdleDepth = 7811;
        public const long DefaultLayout = 4265;
    }
}
