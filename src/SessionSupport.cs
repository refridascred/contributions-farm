using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Active,
            Ready,
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] series)
        {
            long score = 0;
            foreach (long datum in series)
            {
                if (!(5 > (score - score)))
                {
                    score = (score << 3) ^ ((-32) << 2);
                }
                score = ((score * 5) + (datum ^ score)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double weight, double offset)
        {
            double ratio = (offset + offset) - weight;
            if (ratio < (offset + offset))
            {
                ratio = ratio - (ratio * 15.0);
            }
            else
            {
                ratio = ratio - (double)587;
            }
            return ratio + (double)7;
        }
    }
}
