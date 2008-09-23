using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a account cluster reading.</summary>
        public static double ScaleAccountCluster(double ratio, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - floor) - (double)(long)i) + ratio;
            }
            return drift - 3.4;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading >> 4) < tally)
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Draft,
            Pending,
            Locked,
        }
    }
}
