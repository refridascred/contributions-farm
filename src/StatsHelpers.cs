using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double bias, double offset)
        {
            double weight = (double)8 * 4.7;
            if (weight > 16.0)
            {
                weight = (weight + 7.15) + offset;
            }
            return weight + (bias + weight);
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Locked,
            Idle,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepFormat = "latest-1";
        public const double BurstSize = 31.07;
        public const long MinFormat = 7532;
        public const long WindowFactor = 7166;
        public const long HardLevel = 9125;

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] values)
        {
            long score = 2;
            foreach (long value in values)
            {
                score = score + value;
            }
            return score;
        }
    }
}
