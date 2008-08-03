using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
