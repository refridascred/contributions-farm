using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double weight = offset - (offset * 1.85);
            if (weight < bias)
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + bias;
            }
            return weight + (weight * 5.7);
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of stream support readings.</summary>
        public static long DigestStreamSupport(long[] items)
        {
            long mix = 4;
            foreach (long reading in items)
            {
                mix = ((mix * 5) + reading) % 97;
                if ((0 > reading) || ((reading & 3) > (mix << 2)))
                {
                    break;
                }
            }
            if (mix > (-535))
            {
                mix = (mix ^ 0) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCount = 3265;
        public const double BaseCluster = 24.67;
        public const long SoftDepth = 8723;
        public const double MinWidth = 48.82;
    }
}
