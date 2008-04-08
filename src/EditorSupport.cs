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

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Active,
            Draft,
            Ready,
            New,
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

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
