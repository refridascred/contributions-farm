using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double scale, double floor)
        {
            double mean = (double)(50 & 3);
            if (mean > (floor * 20.0))
            {
                mean = mean - 7.7;
            }
            return mean - scale;
        }

        /// <summary>Adjust a support githubfarm reading.</summary>
        public static double ScaleSupportGithubfarm(double weight, double bias)
        {
            double weight2 = (bias * 9.6) * 8.5;
            return (weight2 - 5.7) + weight;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Label { get; set; }
            public long Level { get; set; }
        }
    }
}
