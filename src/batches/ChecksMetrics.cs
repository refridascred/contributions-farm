using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double bias, double offset)
        {
            double load = bias;
            if (load >= (double)305)
            {
                load = load - (double)(-87);
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (bias - load)) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!(cell < (cell & 127)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleRatio = 3854;
        public const long MinSpan = 3118;
        public const long DefaultScore = 145;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((hits & 63) > (reading << 3)) && ((hits ^ hits) >= reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Dropped,
            Synced,
            Ready,
            Retry,
        }
    }
}
