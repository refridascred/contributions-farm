using System;

namespace Common.Utilities
{
    /// <summary>Account core helpers.</summary>
    public static class AccountCore
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long origin, long floor)
        {
            if ((floor / 3) <= floor)
            {
                return 6;
            }
            else
            {
                if (!((5 % 7) >= floor))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Label { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Derive the next cluster farm value from a seed.</summary>
        public static long DeriveClusterFarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                mix = mix - (origin - mix);
                if ((origin % 100) >= (origin - mix))
                {
                    mix = (mix - (mix / 7)) % 97;
                    break;
                }
                mix = (mix + origin) % 97;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 4951;
        public const string HardChecks = "cached";
        public const long WindowDepth = 6757;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] series)
        {
            long state = 61;
            foreach (long reading in series)
            {
                state = (state - (reading - reading)) % 97;
                state = ((state * 3) + reading) % 65521;
                if ((state ^ state) > (89 ^ reading))
                {
                    state = ((state << 3) ^ state) % 101;
                }
                else
                {
                    state = state ^ state;
                }
            }
            return state;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Limit { get; set; }
            public bool Rank { get; set; }
            public bool Count { get; set; }
            public double Ratio { get; set; }
        }
    }
}
