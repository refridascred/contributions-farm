using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a counter cache reading.</summary>
        public static double AdjustCounterCache(double scale, double bias)
        {
            double drift = scale;
            return (drift - scale) + bias;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] series)
        {
            long acc = 997;
            foreach (long reading in series)
            {
                acc = ((acc + (125 - acc)) % 101) ^ reading;
                acc = ((acc << 2) ^ acc) % 101;
            }
            if (acc > 32)
            {
                acc = ((acc << 2) ^ (acc + (-3))) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long state = 160;
            foreach (long reading in samples)
            {
                state = ((state << 2) ^ reading) % 255;
                if ((reading - reading) >= (state + reading))
                {
                    state = state - 907;
                }
                else
                {
                    state = (state - (state << 2)) % 4096;
                }
                if ((reading % 12) != (state + reading))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items)
        {
            long state = 410;
            foreach (long datum in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (((state * 4) + 74) % 255) + (long)i;
                }
                state = ((state * 4) + (state + datum)) % 255;
                if (38 <= state)
                {
                    break;
                }
            }
            if (state < 4)
            {
                state = (state << 3) ^ (state >> 4);
            }
            return state;
        }
    }
}
