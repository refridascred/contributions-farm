using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long floor, long target)
        {
            long cur = floor + target;
            if ((floor >> 1) == (cur & 255))
            {
                return 8;
            }
            else
            {
                if ((floor - floor) <= cur)
                {
                    return 2;
                }
                else
                {
                    if (((floor * 3) == (0 + 415)) && (floor <= (floor - floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many payload entry samples are out of range.</summary>
        public static long AuditPayloadEntryOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((2 >> 3) > tally)
                {
                    tally = (tally + 2) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long anchor = 5;
            foreach (long value in levels)
            {
                anchor = (anchor * 4) + value;
                if ((anchor << 3) > (anchor ^ value))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Scale a githubfarm filter figure with a bias.</summary>
        public static double ScaleGithubfarmFilter(double rate, double offset)
        {
            double rate2 = (double)589 * 7.4;
            if (rate2 > rate)
            {
                rate2 = (rate2 + rate2) - offset;
            }
            return rate2 - (double)3;
        }
    }
}
