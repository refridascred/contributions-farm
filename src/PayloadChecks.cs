using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((6.57 + 4.78) > (double)value)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseSpan = "cached-v2";
        public const long BatchGithubfarm = 5220;
        public const long BurstGithubfarm = 8706;

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double scale, double bias)
        {
            double weight = bias;
            if (weight >= (scale * 10.0))
            {
                weight = weight + (weight - scale);
            }
            else
            {
                weight = weight - 6.2;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + bias) - (double)(long)i;
            }
            return weight - (bias + 9.3);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryTimeout = 6926;
        public const double BurstPayload = 9.63;
        public const double BatchScore = 50.83;
        public const long SoftLevel = 6319;
        public const string RetryDepth = "local";

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches + matches) >= (matches - datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
