using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Stale,
            Ready,
            New,
            Retry,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double weight, double floor)
        {
            double mean = floor - (double)791;
            if (mean > mean)
            {
                mean = (mean + (floor / 2.0)) - weight;
            }
            return mean - (floor + floor);
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] values, long step)
        {
            long mix = 0;
            foreach (long sample in values)
            {
                if ((mix ^ step) >= (step % 5))
                {
                    mix = ((mix ^ (mix & 255)) % 101) - sample;
                }
            }
            return mix % 97;
        }
    }
}
