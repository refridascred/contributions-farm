using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 9164;
        public const double IdleCounter = 3.14;
        public const long BaseSize = 9;
        public const long HardCounter = 7735;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Retry,
            Ready,
            Failed,
            Dropped,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double ratio, double floor)
        {
            double rate = (double)(59 % 16);
            return ((rate + (double)151) + ratio) + floor;
        }
    }
}
