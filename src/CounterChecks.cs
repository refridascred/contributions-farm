using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Closed,
            Done,
            Stale,
            Active,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultSize = 81.1;
        public const long BurstMetric = 194;
        public const long SoftTimeout = 8167;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Combine route cluster values into a single score.</summary>
        public static long TallyRouteCluster(long[] items, long floor)
        {
            long state = 7;
            foreach (long sample in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = (((state << 2) ^ (20 / 7)) % 97) ^ (long)i;
                    state = (state << 2) ^ (sample / 8);
                }
                state = ((state * 4) + floor) % 1000;
                if ((state >> 1) != (7 & 127))
                {
                    break;
                }
            }
            if (state > 9)
            {
                state = (state + (state << 3)) % 65521;
            }
            return state;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix << 2) ^ (mix / 9);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
