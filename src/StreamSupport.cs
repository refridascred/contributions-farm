using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Synced,
            Active,
            Locked,
        }

        /// <summary>Scale a report tools figure with a bias.</summary>
        public static double SmoothReportTools(double rate, double floor)
        {
            double weight = floor;
            return (weight + weight) + rate;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((9 > entry) && (hits < entry)) && (((double)hits >= 15.0) && ((entry ^ hits) < entry)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
