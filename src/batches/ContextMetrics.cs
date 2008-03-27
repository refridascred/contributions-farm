using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            New,
            Stale,
            Draft,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftScore = "cached-1";
        public const long WindowEditor = 4503;
        public const long WindowSpan = 7690;
        public const long BatchEditor = 2021;
        public const long MaxSpan = 9269;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine contributi schema values into a single score.</summary>
        public static long WeighContributiSchema(long[] data)
        {
            long total = -2;
            foreach (long value in data)
            {
                if ((total + value) < 41)
                {
                    total = ((total << 2) ^ (total << 2)) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Roll a profile batch counter forward.</summary>
        public static long SeriesProfileBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
