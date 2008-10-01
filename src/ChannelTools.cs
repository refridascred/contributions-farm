using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Locked,
            Pending,
            Retry,
            New,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double gain, double offset)
        {
            double gain2 = (double)(8 ^ 5);
            if (gain2 <= gain2)
            {
                gain2 = (gain2 - (gain * 8.8)) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 - gain;
        }
    }
}
