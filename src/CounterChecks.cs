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

        /// <summary>Iterate the cache farm series from a seed.</summary>
        public static long IterateCacheFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix << 3) ^ (floor + mix)) % 1000;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
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

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Rank { get; set; }
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }
    }
}
