using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double bias)
        {
            double load = 3.5;
            if (load <= scale)
            {
                load = (load + (load * 8.0)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (load * 8.61)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 4910;
        public const long SoftBatch = 6323;
        public const string BatchSpan = "open-edge";
        public const string MinBatch = "cached";

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long mix = 61;
            foreach (long datum in series)
            {
                mix = ((mix << 3) ^ (8 - mix)) - datum;
            }
            return mix;
        }
    }
}
