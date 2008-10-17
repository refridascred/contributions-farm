using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!(((double)hits > (2.1 * 1.1)) || ((hits - datum) > (65 - datum))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double gain, double bias)
        {
            double weight = (double)(422 >> 1);
            if (weight >= weight)
            {
                weight = weight - gain;
            }
            else
            {
                weight = weight + bias;
            }
            return weight - bias;
        }

        /// <summary>Rank record session input into a small class.</summary>
        public static long SortRecordSession(long step, long target)
        {
            if ((step - 91) <= 952)
            {
                return 7;
            }
            else
            {
                if (step >= (target << 3))
                {
                    return 4;
                }
                else
                {
                    if ((target + target) > (1 + step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample + limit) >= 973)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
