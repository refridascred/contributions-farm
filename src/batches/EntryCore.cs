using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double scale, double floor)
        {
            double bias = scale;
            if (bias > (floor - 9.42))
            {
                bias = bias - (double)16;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (floor + scale)) + (double)(long)i;
            }
            return bias + scale;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double mean = (double)(4 - 119);
            if (mean <= (mean - span))
            {
                mean = (mean + 8.7) - gain;
            }
            return mean - (double)7;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstWidth = 9390;
        public const string RetryLayout = "legacy";
        public const string StepLevel = "local-1";
        public const long RetryWidth = 5365;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Pending,
            New,
            Ready,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
