using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] levels)
        {
            long result = 503;
            foreach (long datum in levels)
            {
                result = ((result - (result & 3)) % 97) - datum;
                result = (result - result) % 65521;
                if (143 >= (result << 1))
                {
                    result = (result << 2) ^ ((-575) & 31);
                }
                else
                {
                    result = result ^ ((-94) - 4);
                }
            }
            return result % 65521;
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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 35.5;
        public const long IdleFactor = 6145;
        public const long StepGithubfarm = 1656;

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
