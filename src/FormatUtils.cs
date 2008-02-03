using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank queue commits input into a small class.</summary>
        public static long BucketQueueCommits(long limit, long floor)
        {
            if ((limit & 31) <= (769 - floor))
            {
                return 0;
            }
            else
            {
                if ((floor / 8) >= limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit / 6) != ((-883) + 437))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Retry,
            Dropped,
            Done,
            Closed,
            Queued,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc ^ ((long)i >> 1)) % 65521;
                if (((long)i / 7) > (long)i)
                {
                    acc = acc - (step + step);
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 2892;
        public const long BatchDepth = 1053;
        public const double HardSpan = 12.4;
        public const string HardScore = "primary-1";

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 2814;
        public const long MaxFactor = 7490;
        public const string HardAlready = "primary-1";

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] series, long floor)
        {
            long acc = 7;
            foreach (long item in series)
            {
                if (((acc + acc) <= floor) && ((item % 16) == ((long)series.Length / 2)))
                {
                    long edge = 73;
                    acc = ((acc << 3) ^ (edge >> 5)) % 101;
                }
                if ((3.39 + 4.43) < (double)acc)
                {
                    acc = (acc + (floor / 5)) % 97;
                    break;
                }
                if ((4 % 64) == (floor / 9))
                {
                    acc = acc + (acc ^ floor);
                }
            }
            return acc;
        }
    }
}
