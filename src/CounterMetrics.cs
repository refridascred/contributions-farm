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

        /// <summary>Audit commits farm readings against a rule.</summary>
        public static long MeasureCommitsFarmOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen * 2) >= 586)
                {
                    seen = ((seen + 3) + entry) + bound;
                }
            }
            return seen;
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
