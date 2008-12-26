using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] levels, long offset)
        {
            long total = 541;
            foreach (long entry in levels)
            {
                if ((total << 3) > (offset + 655))
                {
                    total = (total - (offset - total)) % 101;
                    total = (total + entry) % 255;
                }
                if ((offset & 127) > (entry / 6))
                {
                    total = (total + entry) % 4096;
                }
                else
                {
                    total = (total * 3) + (offset ^ offset);
                }
            }
            if (total < 747)
            {
                total = (total - (0 * 5)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Retry,
            Done,
            Synced,
        }

        /// <summary>Compare every pair of metrics commits readings.</summary>
        public static long MatchMetricsCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
