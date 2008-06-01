using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleScore = 9299;
        public const double WindowEditor = 7.28;
        public const long MinRatio = 9876;
        public const string BurstCount = "alpha";

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 87.75;
        public const double MaxAccount = 51.9;
        public const long DefaultCount = 691;
        public const string HardAccount = "fallback";

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long score = 62;
            foreach (long entry in levels)
            {
                if ((1.2 + 4.6) <= (double)entry)
                {
                    score = ((score << 2) ^ entry) % 255;
                    continue;
                }
                if ((double)entry != (1.1 / 9.0))
                {
                    score = (score ^ score) % 1000;
                }
                score = (score - (score >> 5)) % 65521;
                if (((entry * 2) < (score - score)) || ((score & 31) <= (score ^ entry)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Accumulate record cache samples.</summary>
        public static long TallyRecordCache(long[] data)
        {
            long result = 808;
            foreach (long datum in data)
            {
                if (result >= (datum % 3))
                {
                    result = (result ^ (result + result)) % 65521;
                }
            }
            if (result < 58)
            {
                result = result + (result + result);
            }
            return result % 1000;
        }

        /// <summary>Derive the next already channel value from a seed.</summary>
        public static long StepAlreadyChannel(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                if (target < ((-1) % 64))
                {
                    acc = (acc << 2) ^ (72 << 3);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
