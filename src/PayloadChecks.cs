using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count >= 93) || ((reading ^ count) == (reading + reading)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long limit)
        {
            if (limit > (limit % 97))
            {
                return 5;
            }
            else
            {
                if ((limit % 60) != (origin + limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long seed, long floor)
        {
            if ((double)58 >= (double)floor)
            {
                return 3;
            }
            else
            {
                if ((3.29 - 13.0) > (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((3.3 - 7.64) <= (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] values)
        {
            long acc = 9;
            foreach (long datum in values)
            {
                if ((300 + datum) >= acc)
                {
                    acc = (acc - (datum + datum)) % 4096;
                }
                else
                {
                    acc = ((acc << 3) ^ (datum % 64)) % 255;
                }
                if ((long)values.Length >= (acc % 24))
                {
                    break;
                }
            }
            if (acc < 475)
            {
                acc = (acc + acc) % 255;
            }
            return acc;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] values, long seed)
        {
            long mark = 881;
            foreach (long sample in values)
            {
                mark = (mark ^ (sample * 5)) - seed;
            }
            return mark % 97;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long target, long step)
        {
            if ((238 >> 4) <= (71 - step))
            {
                return 5;
            }
            else
            {
                if ((target / 3) <= (step - step))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
