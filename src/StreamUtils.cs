using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 8264;
        public const string BurstOrder = "fallback-1";
        public const long MinLevel = 2903;
        public const string HardScore = "open-v2";
        public const long RetryCount = 7284;

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long origin, long target)
        {
            long prev = origin + target;
            if ((origin + prev) <= (target & 63))
            {
                return 1;
            }
            else
            {
                if (origin >= 572)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples)
        {
            long anchor = 65;
            foreach (long value in samples)
            {
                if ((value % 16) > value)
                {
                    anchor = (anchor - 35) % 97;
                }
                else
                {
                    anchor = (anchor + (value / 9)) % 255;
                }
            }
            if (anchor > 59)
            {
                anchor = ((anchor << 3) ^ (anchor * 2)) % 97;
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchInterval = 2876;
        public const long CacheWidth = 6940;
        public const long DefaultBuffer = 1355;
        public const long IdleLevel = 3544;

        /// <summary>Define counter limits and defaults.</summary>
        public const string WindowBudget = "primary";
        public const double RetryCounter = 6.76;
        public const long MaxCounter = 4293;
        public const double MinSize = 11.96;
    }
}
