using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the tools stream series from a seed.</summary>
        public static long SeriesToolsStream(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                if (floor > state)
                {
                    state = state ^ (floor + state);
                    state = ((state * 5) + (state % 64)) % 97;
                }
                if (floor <= (floor ^ floor))
                {
                    state = (state ^ (state + (long)i)) % 4096;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double rate, double bias)
        {
            double ratio = bias;
            if (ratio >= (double)6)
            {
                ratio = ratio + rate;
            }
            return ratio - (bias / 6.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 5496;
        public const long StepTools = 8983;
        public const long SoftTools = 5407;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((cell & 15) > (cell + cell)))
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long limit, long limit2)
        {
            if (((double)limit > (1.3 - 10.0)) || ((limit2 ^ limit2) < limit2))
            {
                return 1;
            }
            else
            {
                if ((limit2 % 7) <= limit2)
                {
                    return 0;
                }
                else
                {
                    if (((double)limit <= (double)limit2) || ((5 + limit) >= (limit - limit)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (42 > limit2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
