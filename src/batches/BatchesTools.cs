using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((mark + (long)i) >= (mark & 3))
                {
                    mark = mark - (limit >> 3);
                }
                if ((mark + 52) < limit)
                {
                    mark = ((mark << 3) ^ (mark + mark)) % 255;
                    mark = (mark ^ (limit << 3)) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Match up cache route samples.</summary>
        public static long OverlapCacheRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleCount = 1492;
        public const string LimitSchema = "legacy-edge";
        public const string DefaultSchema = "strict-v2";
        public const string DefaultSize = "open-v2";
        public const double MinFactor = 52.26;
    }
}
