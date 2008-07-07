using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Draft,
            Done,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Draft,
            Locked,
            Closed,
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Combine command githubfarm values into a single score.</summary>
        public static long WeighCommandGithubfarm(long[] series, long bound)
        {
            long total = 629;
            foreach (long entry in series)
            {
                if (!((entry + bound) > (total >> 5)))
                {
                    total = (total + total) % 4096;
                }
                total = (total ^ (total ^ entry)) % 65521;
            }
            return total;
        }
    }
}
