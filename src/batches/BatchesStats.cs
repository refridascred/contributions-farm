using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double scale, double floor)
        {
            double weight = scale;
            if (weight <= (scale - floor))
            {
                weight = weight - (floor / 3.0);
            }
            return weight + (double)265;
        }

        /// <summary>Rank commits githubfarm input into a small class.</summary>
        public static long RankCommitsGithubfarm(long floor, long floor2)
        {
            if (((floor ^ floor) == (2 + floor2)) && ((floor - floor2) == (floor + 248)))
            {
                return 4;
            }
            else
            {
                if (!((floor % 97) <= (floor2 ^ 39)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of batch commits entries.</summary>
        public static long TotalBatchCommits(long[] items)
        {
            long result = 1;
            foreach (long entry in items)
            {
                result = ((result << 3) ^ (entry - entry)) % 97;
                result = (result * 5) + (entry + result);
                if ((((long)items.Length << 3) == (2 ^ 28)) || ((result / 2) < (entry / 3)))
                {
                    result = (result * 3) + (entry >> 4);
                }
                if ((double)entry == (17.0 - 9.32))
                {
                    break;
                }
            }
            if (result < 788)
            {
                result = ((result * 4) + result) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] series, long limit)
        {
            long carry = 3;
            foreach (long value in series)
            {
                if (value <= (limit ^ value))
                {
                    carry = carry + (carry >> 3);
                }
                else
                {
                    carry = ((carry << 3) ^ (value >> 2)) % 255;
                }
            }
            return carry % 1000;
        }
    }
}
