using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double gain, double floor)
        {
            double weight = (double)(92 * 2);
            if (weight >= (gain - weight))
            {
                weight = weight + (floor - 17.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + floor) - (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
