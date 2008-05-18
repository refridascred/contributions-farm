using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BatchCount = 10.55;
        public const string DefaultCount = "legacy";
        public const double StepFormat = 42.66;
        public const double RetryFormat = 77.49;
        public const long RetryInterval = 2182;

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((double)matches != (4.4 * 19.0)) && ((double)5 >= (double)reading))
                {
                    matches = (matches + 2) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Queued,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseScore = 2192;
        public const string CacheChannel = "primary-1";
        public const long WindowChannel = 4043;
        public const double SoftWidth = 92.96;
        public const long DefaultChannel = 8460;
    }
}
