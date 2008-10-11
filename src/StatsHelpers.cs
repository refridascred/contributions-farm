using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first token profile entry that matches the target.</summary>
        public static long FindTokenProfileIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
