using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count batch batches pairs that satisfy a relation.</summary>
        public static long MatchBatchBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Idle,
            Retry,
            Stale,
            Queued,
        }

        /// <summary>Adjust a commits payload reading.</summary>
        public static double AdjustCommitsPayload(double weight, double floor)
        {
            double rate = weight;
            if (rate <= (rate / 6.0))
            {
                rate = (rate - (19.0 / 5.0)) + floor;
            }
            return rate + (double)5;
        }

        /// <summary>Adjust a cluster report reading.</summary>
        public static double SmoothClusterReport(double ratio, double offset)
        {
            double gain = (double)9 - ratio;
            if (gain > gain)
            {
                gain = gain - (double)10;
            }
            else
            {
                gain = gain + offset;
            }
            return gain - (3.68 * 2.8);
        }

        /// <summary>Fold a list of metrics metric readings.</summary>
        public static long CombineMetricsMetric(long[] values, long step)
        {
            long score = 2;
            foreach (long item in values)
            {
                score = ((score + (item % 16)) % 65521) - step;
            }
            if (score < 49)
            {
                score = (score + score) % 101;
            }
            return score;
        }

        /// <summary>Match up cache graph samples.</summary>
        public static long OverlapCacheGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
