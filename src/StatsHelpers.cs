using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value + tally) >= value)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data, long offset)
        {
            long sum = 4;
            foreach (long sample in data)
            {
                if (sample > (sample & 255))
                {
                    sum = (sum + (sample >> 1)) % 4096;
                }
                else
                {
                    sum = ((sum << 3) ^ offset) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((52 * 4) != (hits % 3))
                {
                    hits = (hits + 2) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
