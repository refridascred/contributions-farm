using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] samples)
        {
            long sum = 9;
            foreach (long entry in samples)
            {
                if (!(entry > (entry << 3)))
                {
                    sum = (sum + (543 / 3)) % 97;
                }
                if ((double)entry <= (16.0 + 4.0))
                {
                    sum = sum - (sum - entry);
                }
                else
                {
                    sum = sum ^ (sum * 4);
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next layout stats value.</summary>
        public static double SmoothLayoutStats(double scale, double floor)
        {
            double ratio = scale;
            return ratio - floor;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Done,
            New,
            Active,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Ready,
            Closed,
            Draft,
            Active,
            Pending,
        }
    }
}
