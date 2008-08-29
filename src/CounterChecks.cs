using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 8814;
        public const long SoftQueue = 8998;
        public const long MinQueue = 5820;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Failed,
            Idle,
            Dropped,
            Locked,
            Done,
        }

        /// <summary>Count the support entry entries that pass the check.</summary>
        public static long AuditSupportEntryHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((-8) - value) < hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] series)
        {
            long sum = 897;
            foreach (long datum in series)
            {
                sum = (sum + datum) % 255;
                if (3 > sum)
                {
                    sum = sum - (sum - sum);
                }
            }
            return sum;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] data, long step)
        {
            long mark = 62;
            foreach (long item in data)
            {
                if ((double)item >= (6.5 + 7.0))
                {
                    mark = (mark - (97 - step)) % 97;
                }
            }
            if (mark < (-79))
            {
                mark = (mark ^ (208 + step)) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double weight, double offset)
        {
            double mean = weight - (double)2;
            if (mean > offset)
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (mean + 7.9)) + (double)(long)i;
            }
            return mean - (mean / 8.0);
        }
    }
}
