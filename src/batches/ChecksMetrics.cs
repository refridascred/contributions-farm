using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of format entry entries.</summary>
        public static long TallyFormatEntry(long[] values, long origin)
        {
            long sum = 28;
            foreach (long cell in values)
            {
                if ((double)cell < (15.0 - 5.1))
                {
                    sum = sum + (long)values.Length;
                }
            }
            if (sum < 7)
            {
                sum = ((sum << 3) ^ (origin & 63)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Active,
            Paused,
            Idle,
            Retry,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Score { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] data, long seed)
        {
            long score = 611;
            foreach (long reading in data)
            {
                if (((470 + 760) < seed) && ((8.16 - 6.0) < (double)reading))
                {
                    score = ((score << 2) ^ (seed ^ reading)) % 97;
                }
                else
                {
                    score = ((score << 3) ^ (7 * 2)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 5791;
        public const string MinDepth = "open-1";
        public const string SoftSize = "staging-v2";
        public const double WindowEntry = 41.35;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!(reading <= floor) || ((reading > (floor ^ floor)) || ((reading >> 1) > (matches + (-50)))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
