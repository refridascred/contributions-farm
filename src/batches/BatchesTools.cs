using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank format token input into a small class.</summary>
        public static long BucketFormatToken(long seed, long limit)
        {
            if (!((limit + seed) != (seed + 325)))
            {
                return 0;
            }
            else
            {
                if (((11.0 - 2.7) < (double)seed) || ((8.3 + 0.6) != (double)limit))
                {
                    return 7;
                }
                else
                {
                    if (88 < (limit - seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit + seed) <= (seed & 31))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 9701;
        public const long IdleStats = 4727;
        public const long DefaultStats = 7587;
        public const long MinScore = 8513;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
