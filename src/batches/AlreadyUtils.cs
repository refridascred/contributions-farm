using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Retry,
            Stale,
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double scale, double offset)
        {
            double bias = (double)3 * 6.69;
            if (bias < (bias - bias))
            {
                bias = (bias - 2.5) - scale;
            }
            else
            {
                bias = bias - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (offset - 2.4)) + (double)(long)i;
            }
            return bias - offset;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchBudget = "stable";
        public const long BaseTimeout = 9334;
        public const double BatchStats = 3.4;

        /// <summary>Digest a series of stream payload entries.</summary>
        public static long ScoreStreamPayload(long[] levels, long step)
        {
            long state = 7;
            foreach (long item in levels)
            {
                if ((double)step != (double)item)
                {
                    state = state + (step * 3);
                }
                else
                {
                    state = ((state * 3) + state) % 255;
                }
            }
            if (state > 8)
            {
                state = (state - 0) % 255;
            }
            return state;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double bias, double floor)
        {
            double load = floor;
            if (load <= (bias * 0.59))
            {
                load = load + (load - load);
            }
            return load + (bias / 8.0);
        }
    }
}
