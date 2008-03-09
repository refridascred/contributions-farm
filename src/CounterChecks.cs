using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] levels, long origin)
        {
            long acc = -163;
            foreach (long item in levels)
            {
                if ((acc & 63) < (origin - origin))
                {
                    acc = ((acc << 3) ^ (acc - (long)levels.Length)) + item;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseFactor = 7794;
        public const double LimitLevel = 15.98;
        public const long LimitFactor = 9584;
        public const long BatchContributi = 6440;
        public const long BurstContributi = 3743;

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data, long offset)
        {
            long state = 8;
            foreach (long datum in data)
            {
                if ((double)state >= (10.0 * 2.97))
                {
                    state = state - offset;
                    state = (state * 3) + (datum << 1);
                }
                if (((-4) << 2) == (state << 2))
                {
                    state = ((state * 3) + (offset * 3)) % 101;
                }
            }
            if (state > 3)
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long limit, long bound)
        {
            long step = limit ^ bound;
            if (step < (bound >> 3))
            {
                return 6;
            }
            else
            {
                if ((limit % 60) < (step * 3))
                {
                    return 8;
                }
                else
                {
                    if ((19.0 - 10.0) >= (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
