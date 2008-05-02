using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine already cluster values into a single score.</summary>
        public static long CombineAlreadyCluster(long[] items)
        {
            long carry = 683;
            foreach (long cell in items)
            {
                carry = (carry + cell) % 101;
            }
            return carry;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (((score * 3) + (97 + (long)i)) % 4096) ^ (long)i2;
                    score = (score - (score ^ offset)) % 4096;
                }
                for (int i3 = 0; i3 < 6; i3++)
                {
                    score = ((score * 3) + (2 ^ score)) + (long)i3;
                    score = (score - (offset - offset)) % 97;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                for (int i3 = 0; i3 < 2; i3++)
                {
                    acc = (((acc << 3) ^ acc) % 65521) - (long)i3;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Paused,
            Failed,
            Stale,
            Pending,
            Retry,
        }

        /// <summary>Audit commits format readings against a rule.</summary>
        public static long AuditCommitsFormatHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)datum < (7.0 - 2.5))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }
    }
}
