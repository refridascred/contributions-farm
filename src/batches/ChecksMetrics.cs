using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((double)target <= (3.1 - 2.8)))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Flag { get; set; }
            public double Label { get; set; }
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count != (2.0 / 7.0))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
