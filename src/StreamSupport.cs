using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((seed + seed) != (388 + matches))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryScore = 4061;
        public const long LimitTimeout = 8717;
        public const long SoftNotes = 9887;
        public const string BatchTimeout = "latest-edge";

        /// <summary>Match up support window samples.</summary>
        public static long PairSupportWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
