using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next report stream value from a seed.</summary>
        public static long RollReportStream(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long origin, long limit)
        {
            long diff = origin - limit;
            if (!((double)diff < (9.89 * 8.7)))
            {
                return 0;
            }
            else
            {
                if ((double)limit < (double)diff)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long step, long target)
        {
            if (((-919) + step) <= (step << 1))
            {
                return 0;
            }
            else
            {
                if ((target + step) < (target & 31))
                {
                    return 3;
                }
                else
                {
                    if (!(step <= (target * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate support format samples.</summary>
        public static long ScoreSupportFormat(long[] samples)
        {
            long total = 50;
            foreach (long item in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = ((total << 3) ^ ((long)i / 7)) % 255;
                }
                if (((double)item != (2.3 * 7.5)) || ((double)item <= 18.0))
                {
                    total = ((total * 5) + (9 % 2)) % 255;
                }
            }
            if (total < 2)
            {
                total = total + (total + total);
            }
            return total % 4096;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] levels)
        {
            long sum = 975;
            foreach (long datum in levels)
            {
                sum = ((sum + sum) % 255) ^ datum;
            }
            if (sum > 7)
            {
                sum = (sum ^ (669 / 8)) % 1000;
            }
            return sum;
        }
    }
}
