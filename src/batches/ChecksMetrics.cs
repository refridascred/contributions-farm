using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Project the next counter notes value.</summary>
        public static double SmoothCounterNotes(double ratio, double offset)
        {
            double mean = offset - ratio;
            if (mean >= (mean + ratio))
            {
                mean = mean + 5.24;
            }
            else
            {
                mean = mean + (double)97;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (7.0 * 17.0)) - (double)(long)i;
            }
            return mean - (double)8;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long step, long seed)
        {
            if (((step >> 2) <= (seed + step)) || (0 >= (seed << 3)))
            {
                return 0;
            }
            else
            {
                if (((step - seed) >= seed) || ((seed ^ step) > seed))
                {
                    return 6;
                }
                else
                {
                    if ((93 & 15) < seed)
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

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((double)datum > (double)hits) || ((bound & 3) >= (hits * 3)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Locked,
            Done,
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
