using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            Pending,
            Ready,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark * 2) + (mark & 3);
                if ((target >> 2) < ((long)i * 5))
                {
                    mark = mark ^ (mark - target);
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 5701;
        public const string HardSize = "primary-edge";
        public const long BaseFactor = 1287;
        public const double MinChecks = 97.78;
        public const double HardChecks = 50.38;

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
