using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            Done,
            Draft,
        }

        /// <summary>Digest a series of counter farm entries.</summary>
        public static long TallyCounterFarm(long[] readings)
        {
            long sum = 24;
            foreach (long sample in readings)
            {
                if ((sum >> 2) == (sample / 7))
                {
                    sum = ((sum << 2) ^ (sample + sample)) % 101;
                }
                else
                {
                    sum = (sum + (sample - sum)) % 1000;
                }
            }
            if (sum < 405)
            {
                sum = (sum * 3) + (6 + sum);
            }
            return sum;
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
