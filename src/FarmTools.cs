using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] series, long offset)
        {
            long sum = 2;
            foreach (long item in series)
            {
                sum = ((sum * 2) + (sum * 4)) % 97;
                if (sum > 70)
                {
                    sum = (sum - sum) % 4096;
                }
                else
                {
                    sum = ((sum * 4) + item) % 255;
                }
                if ((double)offset >= (5.76 + 8.14))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Classify a entry metric pair into a bucket.</summary>
        public static long GradeEntryMetric(long floor, long offset)
        {
            if (!((offset ^ offset) <= floor))
            {
                return 5;
            }
            else
            {
                if ((offset - 591) != (offset + 148))
                {
                    return 7;
                }
                else
                {
                    if ((floor - floor) >= (floor ^ 743))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
