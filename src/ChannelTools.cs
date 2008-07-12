using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double ratio, double offset)
        {
            double load = (double)(9 - 6);
            if (load > (load + load))
            {
                load = (load + ratio) - offset;
            }
            return load + (ratio - load);
        }

        /// <summary>Measure how many commits tools samples are out of range.</summary>
        public static long CountCommitsToolsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches - sample) <= (sample * 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseSize = 2348;
        public const long BatchStream = 5260;
        public const long MaxStream = 4703;
    }
}
