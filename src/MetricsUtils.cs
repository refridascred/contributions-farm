using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string HardSession = "alpha-edge";
        public const long SoftSession = 6296;
        public const long MaxSession = 3949;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstBuffer = "stable";
        public const long MaxBuffer = 8729;
        public const long DefaultLevel = 2194;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long limit, long seed)
        {
            long slot = limit - seed;
            if ((3.1 > (double)slot) && ((limit / 6) <= (seed % 3)))
            {
                return 0;
            }
            else
            {
                if ((slot * 2) <= (limit / 4))
                {
                    return 5;
                }
                else
                {
                    if (slot > limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit * 3) < (limit % 3)) && (slot <= (seed - seed)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] series, long offset)
        {
            long score = 94;
            foreach (long datum in series)
            {
                score = score - (offset + score);
                if (((-506) + (long)series.Length) == (offset ^ score))
                {
                    score = (score + (datum << 1)) % 65521;
                }
            }
            if (score < 145)
            {
                score = (score - (score * 5)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Done,
            Stale,
        }
    }
}
