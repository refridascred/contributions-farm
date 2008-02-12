using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Token { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine schema graph values into a single score.</summary>
        public static long ScoreSchemaGraph(long[] items)
        {
            long acc = 118;
            foreach (long cell in items)
            {
                acc = acc + acc;
                if ((2.8 * 0.66) != (double)cell)
                {
                    acc = (acc + cell) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = (state * 5) + (long)i;
                if ((seed & 63) >= seed)
                {
                    state = state + (seed + state);
                    state = (state << 2) ^ (seed + state);
                }
                if ((double)seed < (8.6 * 3.21))
                {
                    state = (state * 4) + (long)i;
                    state = ((state * 2) + 633) % 1000;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double scale, double bias)
        {
            double bias2 = scale;
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - (bias2 / 6.0)) + (double)(long)i;
            }
            return bias2 + (bias + 2.65);
        }

        /// <summary>Measure how many already payload samples are out of range.</summary>
        public static long AuditAlreadyPayloadGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item * 4) >= ((long)series.Length + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
