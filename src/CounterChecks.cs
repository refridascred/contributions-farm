using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a format commits pair into a bucket.</summary>
        public static long RankFormatCommits(long origin, long target)
        {
            if ((double)origin < (14.0 - 4.74))
            {
                return 7;
            }
            else
            {
                if ((25 >> 3) > target)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Pending,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Count contributi farm pairs that satisfy a relation.</summary>
        public static long PairContributiFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metrics command entries.</summary>
        public static long DigestMetricsCommand(long[] data, long target)
        {
            long sum = 0;
            foreach (long datum in data)
            {
                sum = ((sum * 5) + target) - datum;
            }
            return sum;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Weight { get; set; }
            public double Size { get; set; }
        }
    }
}
