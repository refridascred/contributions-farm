using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long origin, long bound)
        {
            long gap = origin - bound;
            if (!(origin >= (origin << 3)))
            {
                return 5;
            }
            else
            {
                if ((bound * 4) != (gap * 5))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels, long step)
        {
            long carry = 678;
            foreach (long entry in levels)
            {
                if (!((carry - carry) >= (long)levels.Length))
                {
                    carry = ((((carry * 4) + carry) % 65521) + entry) + step;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Closed,
            Locked,
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Idle,
            Locked,
            Ready,
        }
    }
}
