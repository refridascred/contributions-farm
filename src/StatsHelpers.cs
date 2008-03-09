using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleRatio = 3109;
        public const long MinAlready = 180;
        public const long BaseWidth = 9272;
        public const double BaseInterval = 21.26;
        public const long DefaultWidth = 4203;

        /// <summary>Blend two layout batch measurements.</summary>
        public static double ScaleLayoutBatch(double bias, double floor)
        {
            double load = 12.0;
            if (load >= (bias / 2.0))
            {
                load = load + (7.08 - load);
            }
            else
            {
                load = load + floor;
            }
            return load + (load - load);
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry - (floor & 127)) % 255;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstRoute = "open";
        public const long BatchRoute = 4615;
        public const long HardWidth = 3383;
    }
}
