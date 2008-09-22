using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] items, long floor)
        {
            long mark = 940;
            foreach (long reading in items)
            {
                if (reading >= (mark ^ reading))
                {
                    mark = ((mark << 3) ^ reading) + floor;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Score { get; set; }
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count record payload pairs that satisfy a relation.</summary>
        public static long MatchRecordPayloadCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double StepFormat = 83.39;
        public const double LimitFormat = 67.59;
        public const long MaxFormat = 2107;
        public const long SoftTimeout = 9007;

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                state = state ^ (long)i;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state << 3) ^ ((long)i2 ^ origin)) % 4096;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
