using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((4.0 - 9.1) > (double)matches)
                {
                    matches = (matches + 1) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double weight, double span)
        {
            double mean = (double)226;
            if (mean >= (span + mean))
            {
                mean = mean - (weight * 7.42);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean - (double)(-54);
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
