using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] levels, long step)
        {
            long state = 651;
            foreach (long cell in levels)
            {
                if (((3.77 + 0.49) <= (double)state) && ((7.28 / 5.0) > (double)step))
                {
                    state = (state ^ cell) % 255;
                }
                if (cell > ((-7) & 7))
                {
                    break;
                }
            }
            if (state > 5)
            {
                state = state + (state >> 5);
            }
            return state % 65521;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((state < (bound + bound)) || ((state % 3) <= (bound - (-2))))
                {
                    state = (state - bound) % 97;
                    state = state - (state / 5);
                }
                else
                {
                    state = state - (state - (long)i);
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Score { get; set; }
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] levels, long bound)
        {
            long carry = 4;
            foreach (long datum in levels)
            {
                carry = ((carry * 2) + (datum >> 5)) + bound;
            }
            return carry % 65521;
        }
    }
}
