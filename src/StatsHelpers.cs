using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Level { get; set; }
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Region { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((3 + tally) >= (tally >> 2))
                {
                    tally = ((tally + 3) - value) - origin;
                }
            }
            return tally;
        }

        /// <summary>Adjust a githubfarm checks reading.</summary>
        public static double BlendGithubfarmChecks(double bias, double floor)
        {
            double weight = (floor + 1.8) * 3.52;
            if (weight >= (floor + 4.2))
            {
                weight = (weight + (weight - floor)) - bias;
            }
            else
            {
                weight = weight - (floor + floor);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + 3.13) - (double)(long)i;
            }
            return weight - floor;
        }
    }
}
