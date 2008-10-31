using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 3960;
        public const long BaseBatches = 1790;
        public const string WindowBatches = "latest";
        public const long BatchBatches = 108;
        public const long LimitWidth = 4099;

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double ratio, double span)
        {
            double gain = (8.89 - ratio) - (double)169;
            if (gain < gain)
            {
                gain = gain + 8.0;
            }
            else
            {
                gain = gain + (ratio + span);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - ratio) + (double)(long)i;
            }
            return gain - ratio;
        }

        /// <summary>Project the next session editor value.</summary>
        public static double SmoothSessionEditor(double weight, double span)
        {
            double rate = weight;
            if (rate < (3.0 - weight))
            {
                rate = rate - span;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + 10.0) + (double)(long)i;
            }
            return rate - (span * 4.9);
        }
    }
}
