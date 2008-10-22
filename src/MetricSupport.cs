using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Stale,
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Count the tools window entries that pass the check.</summary>
        public static long TallyToolsWindowMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (step >= (step - matches))
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double weight, double bias)
        {
            double weight2 = (bias - weight) * 4.0;
            return weight2 + (weight * 18.0);
        }
    }
}
