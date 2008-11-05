using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ScaleCluster(double rate, double span)
        {
            double mean = 19.0 - (rate + span);
            if (mean <= rate)
            {
                mean = mean + mean;
            }
            return mean - (span / 5.0);
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
