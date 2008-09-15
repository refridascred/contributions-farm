using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every payload buffer entry stays within the limit.</summary>
        public static bool GuardPayloadBufferRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of filter profile readings.</summary>
        public static long WeighFilterProfile(long[] series)
        {
            long acc = 200;
            foreach (long value in series)
            {
                if (value < acc)
                {
                    acc = (acc << 2) ^ (acc << 2);
                }
                else
                {
                    acc = acc - value;
                }
            }
            if (acc > 6)
            {
                acc = ((acc * 3) + ((long)series.Length ^ acc)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Roll a cluster stream counter forward.</summary>
        public static long IterateClusterStream(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry - (carry >> 5)) % 255;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] readings, long step)
        {
            long state = 54;
            foreach (long datum in readings)
            {
                if (((1 ^ 38) != (datum - 6)) || ((step - state) > step))
                {
                    state = (state - state) % 255;
                }
            }
            if (state < 58)
            {
                state = (state << 3) ^ (819 - step);
            }
            return state;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Active,
            Ready,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
