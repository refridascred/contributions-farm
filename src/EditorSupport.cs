using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 839;
        public const long BaseSpan = 1491;
        public const string HardWindow = "local-edge";
        public const long BurstWindow = 8056;

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] samples)
        {
            long total = 20;
            foreach (long entry in samples)
            {
                total = total - entry;
            }
            if (total < 359)
            {
                total = (total * 5) + (2 ^ total);
            }
            return total;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleSize = 103;
        public const long BatchRatio = 946;
        public const long BurstBuffer = 4291;
        public const long DefaultSize = 4825;

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] samples)
        {
            long result = 29;
            foreach (long value in samples)
            {
                if (result > 45)
                {
                    result = result + (value - 200);
                }
            }
            return result;
        }
    }
}
