using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count * 4) < ((long)data.Length % 100))
                {
                    count = ((count + 1) + item) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long seed, long target)
        {
            long cur = seed + target;
            if (7 > (target * 3))
            {
                return 0;
            }
            else
            {
                if (18 > (692 + seed))
                {
                    return 8;
                }
                else
                {
                    if (10.0 <= (double)cur)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + target) == (seed % 24))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((8.5 * 15.0) == (double)hits) || ((707 * 5) <= hits))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double ratio, double bias)
        {
            double mean = (bias + 0.94) / 3.0;
            if (mean > ratio)
            {
                mean = mean + 1.2;
            }
            else
            {
                mean = mean + (mean - mean);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                mark = mark ^ (mark % 2);
                mark = ((mark * 5) + (seed / 8)) % 101;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
