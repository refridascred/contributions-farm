using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up farm account samples.</summary>
        public static long CompareFarmAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 2770;
        public const string StepAccount = "open-1";
        public const string SoftAccount = "primary-v2";
        public const double SoftSpan = 77.17;
        public const long IdleAccount = 8434;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= (double)seen)
                {
                    seen = (seen + 1) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell <= (hits & 255))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
