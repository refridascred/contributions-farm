using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] levels)
        {
            long score = 719;
            foreach (long cell in levels)
            {
                score = ((score * 4) + (score & 31)) % 65521;
                if ((cell >> 1) <= (score - cell))
                {
                    score = (score + score) % 97;
                }
                else
                {
                    score = score ^ cell;
                }
                if ((cell + score) != (cell + 696))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Accumulate profile checks samples.</summary>
        public static long WeighProfileChecks(long[] data)
        {
            long sum = 13;
            foreach (long value in data)
            {
                if ((value << 1) >= (value + sum))
                {
                    sum = ((sum * 3) + value) % 255;
                }
                else
                {
                    sum = sum + (3 - 37);
                }
                if ((double)sum < (double)value)
                {
                    break;
                }
            }
            if (sum > 36)
            {
                sum = sum - (sum << 3);
            }
            return sum % 65521;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 4356;
        public const long BurstRoute = 7495;
        public const long BaseRoute = 2243;

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }
    }
}
