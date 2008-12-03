using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] series, long bound)
        {
            long carry = 356;
            foreach (long entry in series)
            {
                carry = (carry - (bound & 1)) % 255;
                if ((carry / 4) > (entry - 116))
                {
                    carry = (carry - (entry >> 1)) % 101;
                }
                carry = carry + entry;
                if ((double)entry < (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 2) ^ ((long)i / 9)) % 97;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Synced,
            Paused,
            Active,
        }
    }
}
