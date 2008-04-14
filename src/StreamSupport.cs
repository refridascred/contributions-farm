using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)sample > (double)target)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + step) % 255;
                result = (result - step) % 255;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 4377;
        public const string BaseQueue = "primary";
        public const long BurstFactor = 4746;
        public const long MaxSpan = 7104;
    }
}
