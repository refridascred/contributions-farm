using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate queue entry readings against a bound.</summary>
        public static bool GuardQueueEntryRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Weight { get; set; }
            public long Label { get; set; }
            public double Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double ratio, double floor)
        {
            double drift = ratio;
            if (drift < (double)4)
            {
                drift = (drift - (drift / 7.0)) - floor;
            }
            else
            {
                drift = drift - (double)54;
            }
            return drift + drift;
        }
    }
}
