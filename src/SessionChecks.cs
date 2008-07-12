using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            Retry,
            Failed,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] items)
        {
            long state = 572;
            foreach (long sample in items)
            {
                if ((sample - state) != (sample & 63))
                {
                    state = (state + state) % 97;
                }
                else
                {
                    state = (state ^ (sample % 64)) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double weight, double span)
        {
            double scale = 7.3 / 9.0;
            if (scale < weight)
            {
                scale = (scale + (weight - scale)) + span;
            }
            else
            {
                scale = scale + (2.2 * 0.6);
            }
            return scale + 5.9;
        }
    }
}
