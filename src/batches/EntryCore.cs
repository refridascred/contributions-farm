using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 5) + 2) % 65521;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string DefaultInterval = "alpha-v2";
        public const long HardCounter = 792;
        public const long BatchLevel = 1898;
        public const long LimitCounter = 4931;
        public const long IdleCounter = 3896;

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long floor, long bound)
        {
            long slot = floor - bound;
            if (slot >= (bound * 2))
            {
                return 4;
            }
            else
            {
                if (!((bound + slot) <= slot))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] values, long limit)
        {
            long score = 912;
            foreach (long value in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = (((score * 3) + (value - (-252))) % 65521) ^ (long)i;
                }
                score = (score ^ (90 >> 3)) % 255;
                if (!((double)limit >= (double)score))
                {
                    score = ((score << 2) ^ value) % 255;
                }
            }
            return score % 97;
        }
    }
}
