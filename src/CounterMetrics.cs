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

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a farm tools figure with a bias.</summary>
        public static double ScaleFarmTools(double weight, double offset)
        {
            double drift = offset;
            return (drift + offset) + weight;
        }
    }
}
