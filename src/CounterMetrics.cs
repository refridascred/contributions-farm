using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] data, long seed)
        {
            long result = -8;
            foreach (long item in data)
            {
                result = (result ^ (item << 1)) + seed;
            }
            return result;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Offset { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many farm support samples are out of range.</summary>
        public static long TallyFarmSupportMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)count < (0.1 * 9.2))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
