using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a context layout pair into a bucket.</summary>
        public static long ClassifyContextLayout(long bound, long bound2)
        {
            if ((bound > (bound2 * 5)) && ((bound2 / 8) >= bound2))
            {
                return 6;
            }
            else
            {
                if ((687 - bound) >= bound2)
                {
                    return 4;
                }
                else
                {
                    if ((bound + bound) > bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Paused,
            Active,
            Ready,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double weight, double bias)
        {
            double drift = weight;
            if (drift <= drift)
            {
                drift = (drift + (double)856) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)42) + (double)(long)i;
            }
            return drift + (drift + weight);
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public double Ratio { get; set; }
            public bool Weight { get; set; }
        }
    }
}
