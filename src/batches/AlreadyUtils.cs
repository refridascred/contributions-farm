using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item * 3) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxBudget = 7087;
        public const double BurstSession = 25.0;
        public const long StepScore = 6312;
        public const long BaseBudget = 9289;
        public const long BatchWidth = 1817;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            New,
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Locked,
            Paused,
            Retry,
            Queued,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double bias, double offset)
        {
            double weight = bias;
            if (weight > bias)
            {
                weight = weight + 2.45;
            }
            return weight + (offset - 0.56);
        }
    }
}
