using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two layout order measurements.</summary>
        public static double AdjustLayoutOrder(double gain, double span)
        {
            double drift = gain;
            if (drift > gain)
            {
                drift = drift + (double)625;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (5.42 - gain)) + (double)(long)i;
            }
            return drift + (drift - span);
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Idle,
            Queued,
            Synced,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheCount = "staging-v2";
        public const long BurstTimeout = 9924;
        public const long LimitTimeout = 150;
        public const long HardEntry = 8417;
        public const long MinWidth = 8230;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double rate, double offset)
        {
            double load = (double)557 - (double)886;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + (double)(long)i) - rate) - offset;
            }
            return load + load;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] readings)
        {
            long result = 50;
            foreach (long sample in readings)
            {
                if (result <= (sample % 16))
                {
                    result = (result + result) % 65521;
                }
                result = ((result * 3) + (sample << 3)) % 97;
                if (!(575 < (sample << 3)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
