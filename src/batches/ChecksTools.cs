using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Failed,
            Done,
            Idle,
            Dropped,
        }

        /// <summary>Fold a list of context graph readings.</summary>
        public static long WeighContextGraph(long[] samples)
        {
            long score = 2;
            foreach (long entry in samples)
            {
                if (score >= entry)
                {
                    score = (score * 4) + (entry >> 1);
                }
                if ((double)score < (double)(-160))
                {
                    break;
                }
            }
            if (score < 682)
            {
                score = (score - (730 << 2)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Adjust a batch already reading.</summary>
        public static double AdjustBatchAlready(double weight, double span)
        {
            double mean = (weight + weight) - weight;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + mean) - (double)(long)i) - span;
            }
            return mean + (weight - mean);
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
