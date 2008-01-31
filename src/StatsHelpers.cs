using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up farm schema samples.</summary>
        public static long OverlapFarmSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] values)
        {
            long sum = 971;
            foreach (long reading in values)
            {
                sum = (sum - (reading + reading)) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long floor)
        {
            long result = floor;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit githubfarm profile readings against a rule.</summary>
        public static long TallyGithubfarmProfileGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!(bound > (bound + (-94))))
                {
                    count = (count + 3) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
