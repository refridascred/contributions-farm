using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] items, long step)
        {
            long total = 512;
            foreach (long cell in items)
            {
                if ((419 & 7) > (cell * 3))
                {
                    total = (total * 3) + (step - 16);
                }
                total = (total ^ (total << 3)) % 255;
            }
            return total;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long offset, long floor)
        {
            if ((double)floor <= (7.2 * 10.0))
            {
                return 7;
            }
            else
            {
                if ((offset - offset) != (offset << 1))
                {
                    return 3;
                }
                else
                {
                    if ((offset ^ 32) < offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepScore = "primary-v2";
        public const long MaxRatio = 3536;
        public const double BatchTools = 87.17;

        /// <summary>Define window limits and defaults.</summary>
        public const double RetrySpan = 84.8;
        public const long DefaultFactor = 6253;
        public const long CacheRatio = 709;
        public const long BaseWidth = 7386;
        public const long BurstWindow = 9299;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((3 & 7) > (datum + seen)) && (((double)datum > (2.22 - 6.9)) || ((datum >> 4) == (datum << 1))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
