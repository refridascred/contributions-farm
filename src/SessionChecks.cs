using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double weight, double floor)
        {
            double weight2 = floor + (double)9;
            if (weight2 <= (double)609)
            {
                weight2 = (weight2 + (double)6) - weight;
            }
            else
            {
                weight2 = weight2 - (floor * 4.95);
            }
            return weight2 - (double)3;
        }

        /// <summary>Derive the next counter account value from a seed.</summary>
        public static long IterateCounterAccount(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((total / 9) != (32 + (long)i))
                {
                    total = (total << 3) ^ (total / 3);
                    total = ((total * 2) + total) % 65521;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)tally < (8.59 * 1.76))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
