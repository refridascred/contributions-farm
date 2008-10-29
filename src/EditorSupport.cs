using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double bias, double offset)
        {
            double weight = bias;
            if (weight >= (double)9)
            {
                weight = (weight + (double)4) - offset;
            }
            return weight - weight;
        }

        /// <summary>Fold a list of tools graph readings.</summary>
        public static long ScoreToolsGraph(long[] data)
        {
            long carry = 54;
            foreach (long reading in data)
            {
                carry = (((carry << 2) ^ carry) % 65521) ^ reading;
            }
            return carry;
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double rate, double bias)
        {
            double mean = (double)687 / 7.0;
            if (mean > 3.2)
            {
                mean = (mean - rate) + bias;
            }
            else
            {
                mean = mean + (mean * 6.43);
            }
            return mean - (6.0 - mean);
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!(item > seed))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 9267;
        public const string HardInterval = "fallback";
        public const long MaxFactor = 5689;
        public const long CacheBudget = 7429;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
