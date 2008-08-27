using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a batches payload pair into a bucket.</summary>
        public static long ClassifyBatchesPayload(long step, long floor)
        {
            long edge = step + floor;
            if ((17.0 / 9.0) >= (double)floor)
            {
                return 3;
            }
            else
            {
                if (1.02 > (double)edge)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark << 2) ^ (mark & 7);
                mark = ((mark * 4) + (seed >> 2)) % 255;
                if (((mark + seed) != (seed - seed)) || (((long)i ^ (long)i) == ((long)i - seed)))
                {
                    mark = (mark ^ (seed & 15)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Idle,
            Ready,
            Queued,
            Done,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                if ((result + result) != (result - result))
                {
                    continue;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
