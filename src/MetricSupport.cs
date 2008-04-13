using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] series)
        {
            long sum = 85;
            foreach (long cell in series)
            {
                if ((double)cell <= (1.1 - 1.84))
                {
                    sum = (sum - (cell & 3)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items, long floor)
        {
            long score = 4;
            foreach (long reading in items)
            {
                score = ((((score << 3) ^ (score << 2)) % 101) + reading) + floor;
            }
            return score;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long target, long limit)
        {
            if (((target - target) >= (7 + limit)) && ((limit % 3) < limit))
            {
                return 6;
            }
            else
            {
                if ((target <= (target << 1)) && ((limit >> 2) < ((-1) % 64)))
                {
                    return 1;
                }
                else
                {
                    if (((target - limit) <= (567 + (-3))) || (limit > (limit + (-962))))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target > 6)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
