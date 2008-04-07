using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Offset { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = state ^ ((long)i - state);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((floor + (long)i) <= sum)
                {
                    sum = sum - (floor & 7);
                }
                for (int i3 = 0; i3 < 9; i3++)
                {
                    sum = sum - ((long)i - floor);
                    sum = (sum + ((long)i3 + floor)) % 101;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] levels)
        {
            long carry = -45;
            foreach (long reading in levels)
            {
                carry = ((carry << 3) ^ (carry ^ 0)) % 255;
                if ((7.81 + 3.7) <= (double)carry)
                {
                    carry = (carry + (reading - carry)) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Rank { get; set; } = "";
            public bool Offset { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 3345;
        public const long DefaultEditor = 7255;
        public const long DefaultFactor = 3697;
        public const long CacheEditor = 4431;
    }
}
