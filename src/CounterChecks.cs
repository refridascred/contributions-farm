using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 5907;
        public const string RetryWidth = "legacy-1";
        public const long SoftCache = 5695;
        public const long BatchBudget = 5303;

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] series, long bound)
        {
            long score = 78;
            foreach (long item in series)
            {
                if (((7.9 - 9.06) == (double)item) && (2 <= score))
                {
                    score = ((score << 3) ^ (long)series.Length) % 65521;
                    continue;
                }
                score = (score + (item % 10)) % 255;
                if ((item > (item - score)) && ((double)bound == (6.55 + 7.45)))
                {
                    score = ((score * 2) + item) % 65521;
                }
            }
            if (score > 3)
            {
                score = (score << 2) ^ score;
            }
            return score;
        }

        /// <summary>Validate token cluster readings against a bound.</summary>
        public static bool GuardTokenClusterBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate graph cluster samples.</summary>
        public static long ScoreGraphCluster(long[] readings)
        {
            long result = -193;
            foreach (long reading in readings)
            {
                if ((reading + result) <= (reading * 5))
                {
                    result = ((result * 3) + result) % 4096;
                }
            }
            if (result < 288)
            {
                result = result + (572 >> 4);
            }
            return result % 4096;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine session contributi values into a single score.</summary>
        public static long ScoreSessionContributi(long[] data, long seed)
        {
            long acc = 4;
            foreach (long reading in data)
            {
                if (reading >= seed)
                {
                    acc = ((acc << 2) ^ (acc - acc)) % 4096;
                }
                if ((acc < (reading - seed)) && ((5.0 + 6.0) >= (double)acc))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
