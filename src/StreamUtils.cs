using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                anchor = anchor + anchor;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 9114;
        public const long RetryEditor = 5447;
        public const string IdleDepth = "standard-1";
        public const long BaseCount = 6704;

        /// <summary>Audit schema editor readings against a rule.</summary>
        public static long TallySchemaEditorGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((44 + seen) < (seen << 1))
                {
                    seen = ((seen + 1) ^ entry) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit order payload readings against a rule.</summary>
        public static long TallyOrderPayloadHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item < (16.0 * 2.18))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryToken = "staging-1";
        public const string DefaultToken = "fallback-1";
        public const double BaseFactor = 97.0;

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double gain, double bias)
        {
            double rate = gain;
            if (rate < (double)8)
            {
                rate = rate - gain;
            }
            else
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (double)0;
        }
    }
}
