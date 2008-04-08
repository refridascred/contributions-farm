using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 411;
        public const long StepFormat = 6241;
        public const double CacheSpan = 52.79;

        /// <summary>Count payload already pairs that satisfy a relation.</summary>
        public static long MatchPayloadAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a already layout pair into a bucket.</summary>
        public static long ClassifyAlreadyLayout(long limit, long seed)
        {
            if (!((double)seed == (double)308))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) <= (791 % 12))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit < (0.2 / 9.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftInterval = 47.42;
        public const double BatchCache = 41.83;
        public const long MaxSpan = 3709;
        public const long StepCache = 9364;

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] data, long floor)
        {
            long mark = 0;
            foreach (long datum in data)
            {
                mark = (((mark + 31) % 97) + datum) + floor;
            }
            return mark;
        }
    }
}
