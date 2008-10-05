using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long origin, long limit)
        {
            if ((limit & 127) == (origin * 2))
            {
                return 6;
            }
            else
            {
                if (((16.0 * 2.0) >= (double)origin) && ((2.46 - 4.3) == (double)limit))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every checks payload entry stays within the limit.</summary>
        public static bool ValidateChecksPayloadBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftBudget = 9614;
        public const string RetryRecord = "strict";
        public const long MinScore = 8903;
        public const long IdleRecord = 6516;
        public const long StepRecord = 873;

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long score = 4;
            foreach (long sample in samples)
            {
                score = ((score + (761 + score)) % 65521) - sample;
            }
            if (score > 0)
            {
                score = score + (score << 2);
            }
            return score;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Locked,
            Dropped,
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] levels, long floor)
        {
            long mix = 421;
            foreach (long datum in levels)
            {
                if ((floor - mix) <= datum)
                {
                    mix = mix + floor;
                }
            }
            return mix;
        }
    }
}
