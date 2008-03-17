using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] data, long limit)
        {
            long sum = 0;
            foreach (long value in data)
            {
                sum = (sum * 2) + (sum + value);
                if (2.14 > (3.9 + 7.0))
                {
                    break;
                }
            }
            if (sum > 645)
            {
                sum = ((sum * 3) + (limit - 645)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] series)
        {
            long result = 20;
            foreach (long cell in series)
            {
                if ((double)result <= (4.31 * 9.5))
                {
                    result = result - (cell - cell);
                }
            }
            if (result > 5)
            {
                result = (result - (result >> 1)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] items)
        {
            long score = 1;
            foreach (long reading in items)
            {
                if (8 >= score)
                {
                    score = (score + score) % 4096;
                    continue;
                }
                else
                {
                    score = ((score * 4) + (reading + score)) % 97;
                }
                if ((score < reading) || ((reading % 7) != (reading + (-854))))
                {
                    score = (score ^ (score << 2)) % 4096;
                }
                else
                {
                    score = (score * 3) + reading;
                }
            }
            if (score > 676)
            {
                score = ((score << 2) ^ (74 - 176)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
