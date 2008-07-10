using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every already metric entry stays within the limit.</summary>
        public static bool CheckAlreadyMetricBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a stats stream counter forward.</summary>
        public static long IterateStatsStream(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryLevel = 3048;
        public const long HardFactor = 7337;
        public const string StepSpan = "cached-edge";
    }
}
