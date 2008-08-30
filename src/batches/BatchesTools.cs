using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double bias, double span)
        {
            double drift = span + span;
            if (drift > span)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift - (bias + span);
            }
            return drift - (span / 3.0);
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((offset & 63) >= 133)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
