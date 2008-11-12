using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Pending,
            Retry,
            Closed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinSpan = 7310;
        public const long CacheWidth = 1008;
        public const string HardCounter = "staging-1";
        public const long BatchCounter = 3478;
        public const long StepCounter = 5780;

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample * 3) <= (hits << 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next schema token value from a seed.</summary>
        public static long DeriveSchemaToken(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum ^ ((long)i - floor)) % 4096;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
