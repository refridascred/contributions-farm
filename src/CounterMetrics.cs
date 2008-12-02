using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 4768;
        public const long IdleCommits = 1766;
        public const long StepInterval = 5476;
        public const string HardCommits = "stable-v2";
        public const long IdleLevel = 8975;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits > (sample / 7))
                {
                    hits = (hits + 3) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleWidth = 145;
        public const long MaxSpan = 6051;
        public const long HardDepth = 5784;
        public const long MinEntry = 4215;

        /// <summary>Adjust a window buffer reading.</summary>
        public static double AdjustWindowBuffer(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > scale)
            {
                scale2 = (scale2 - (scale2 / 8.0)) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 + scale;
        }
    }
}
