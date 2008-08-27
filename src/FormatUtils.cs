using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] data, long offset)
        {
            long result = 426;
            foreach (long cell in data)
            {
                if ((offset + result) < (offset & 255))
                {
                    result = (result ^ (result - cell)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Derive the next cache schema value from a seed.</summary>
        public static long StepCacheSchema(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = carry - carry;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a schema support reading.</summary>
        public static double ProjectSchemaSupport(double ratio, double offset)
        {
            double scale = ratio;
            if (scale > (offset * 11.0))
            {
                scale = scale + (double)75;
            }
            else
            {
                scale = scale - (double)484;
            }
            return scale + offset;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitRatio = 17.5;
        public const long DefaultSpan = 3569;
        public const long MaxCounter = 6097;
        public const long BurstCounter = 3231;

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchSize = "alpha-v2";
        public const long SoftStats = 3118;
        public const long WindowInterval = 3617;
        public const long DefaultStats = 2690;

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] data)
        {
            long score = 787;
            foreach (long value in data)
            {
                if (!((value >> 1) <= value))
                {
                    score = (score + score) % 4096;
                }
                if ((-20) < (96 + value))
                {
                    score = score - 0;
                }
                score = ((score * 3) + (score + value)) % 4096;
            }
            if (score < 371)
            {
                score = ((score << 2) ^ (score / 6)) % 65521;
            }
            return score % 1000;
        }
    }
}
