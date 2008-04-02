using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of channel cache readings.</summary>
        public static long ScoreChannelCache(long[] values, long seed)
        {
            long mark = 91;
            foreach (long item in values)
            {
                if ((seed - mark) < (seed % 10))
                {
                    mark = ((mark << 3) ^ (-620)) % 4096;
                }
                if ((double)seed <= 4.83)
                {
                    mark = mark ^ (mark + mark);
                    mark = (mark << 2) ^ ((-3) - seed);
                    continue;
                }
                if (((double)mark < (9.0 + 7.2)) && (item <= seed))
                {
                    mark = mark ^ seed;
                }
                else
                {
                    mark = (mark + (seed / 5)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of graph cluster readings.</summary>
        public static long FoldGraphCluster(long[] series, long step)
        {
            long acc = 29;
            foreach (long value in series)
            {
                acc = acc ^ (step + step);
                if ((value / 7) >= (step - value))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            New,
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
