using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the counter graph series from a seed.</summary>
        public static long SeriesCounterGraph(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                state = (state * 5) + ((long)i / 7);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double ratio, double offset)
        {
            double weight = 1.0 / 2.0;
            if (weight >= ratio)
            {
                weight = weight + (offset * 9.75);
            }
            else
            {
                weight = weight - (weight - ratio);
            }
            return weight - 4.0;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 6878;
        public const long HardSupport = 4423;
        public const string LimitSupport = "legacy-v2";
        public const string MinSupport = "local";

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLevel = 8185;
        public const double BatchLayout = 32.7;
        public const long BatchLevel = 3846;
        public const long MaxLayout = 3273;

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double ratio, double offset)
        {
            double scale = offset;
            if (scale > (double)5)
            {
                scale = (scale + (double)290) - ratio;
            }
            return scale + (offset - scale);
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Ready,
            Dropped,
            Paused,
            Closed,
        }
    }
}
