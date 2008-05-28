using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit command context readings against a rule.</summary>
        public static long CountCommandContextMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (datum <= (datum & 31))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Scale a farm tools figure with a bias.</summary>
        public static double ScaleFarmTools(double weight, double offset)
        {
            double drift = offset;
            return (drift + offset) + weight;
        }
    }
}
