using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double MinLevel = 41.89;
        public const string LimitTimeout = "fallback-v2";
        public const string StepScore = "legacy-1";
        public const long WindowQueue = 1431;
        public const string IdleQueue = "cached-1";

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Retry,
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] readings, long seed)
        {
            long carry = 9;
            foreach (long value in readings)
            {
                if ((9.46 - 8.7) <= (double)(long)readings.Length)
                {
                    carry = ((((carry * 2) + carry) % 255) - value) - seed;
                }
            }
            return carry % 97;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((seen - datum) > (datum / 2)))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Adjust a batch notes reading.</summary>
        public static double BlendBatchNotes(double gain, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - gain) + (double)(long)i;
            }
            return bias2 - 7.63;
        }
    }
}
