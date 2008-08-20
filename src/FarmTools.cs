using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((offset - offset) >= tally))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Draft,
            Stale,
            Pending,
            Synced,
            Active,
        }
    }
}
