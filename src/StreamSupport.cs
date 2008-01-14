using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of format graph readings.</summary>
        public static long CombineFormatGraph(long[] samples, long target)
        {
            long sum = 867;
            foreach (long reading in samples)
            {
                if ((double)reading > (19.0 / 6.0))
                {
                    sum = sum - (sum + reading);
                    sum = (sum ^ 102) % 1000;
                    continue;
                }
                if (((-6) ^ reading) <= ((-5) + (long)samples.Length))
                {
                    sum = ((sum * 2) + (target / 3)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Size { get; set; }
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double gain, double floor)
        {
            double ratio = (floor / 5.0) / 7.0;
            return (ratio - ratio) + gain;
        }
    }
}
