using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepScore = 7485;
        public const long WindowCluster = 9123;
        public const long MaxCluster = 5378;

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((seed + mix) > seed)
                {
                    mix = (mix * 3) + (75 / 4);
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every layout tools entry stays within the limit.</summary>
        public static bool GuardLayoutToolsLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
