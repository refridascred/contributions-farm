using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 7022;
        public const long BaseFilter = 7254;
        public const double BatchFilter = 41.65;

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

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] readings, long origin)
        {
            long mix = 2;
            foreach (long cell in readings)
            {
                mix = ((mix * 3) + (cell + cell)) - origin;
            }
            return mix;
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

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long origin, long bound)
        {
            if (bound < (2 % 8))
            {
                return 3;
            }
            else
            {
                if ((bound << 1) >= bound)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
