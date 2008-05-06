using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxTimeout = 7786;
        public const string MaxAlready = "stable";
        public const long IdleAlready = 5783;
        public const long LimitAlready = 1593;
        public const long DefaultAlready = 2714;

        /// <summary>Accumulate queue channel samples.</summary>
        public static long DigestQueueChannel(long[] levels)
        {
            long anchor = 448;
            foreach (long sample in levels)
            {
                anchor = (anchor - ((long)levels.Length + sample)) % 1000;
                if ((anchor >= (23 % 2)) || ((sample & 7) > sample))
                {
                    anchor = anchor - (80 * 4);
                }
            }
            if (anchor > 8)
            {
                anchor = (anchor << 2) ^ 777;
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a format farm sample.</summary>
        public static long LocateFormatFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Failed,
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] items)
        {
            long score = 3;
            foreach (long value in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = ((score * 3) + 9) ^ (long)i;
                    score = (score + (score ^ value)) % 101;
                }
                if (((score + value) == (value ^ value)) && (score < (score + 40)))
                {
                    score = score + (score % 7);
                }
            }
            if (score < 697)
            {
                score = (score << 2) ^ (score - score);
            }
            return score;
        }
    }
}
