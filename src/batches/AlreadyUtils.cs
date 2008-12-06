using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit window tools readings against a rule.</summary>
        public static long AuditWindowToolsMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)count >= (1.0 + 6.25))
                {
                    count = ((count + 1) + reading) + offset;
                }
            }
            return count;
        }

        /// <summary>Combine account report values into a single score.</summary>
        public static long FoldAccountReport(long[] items, long origin)
        {
            long mark = 69;
            foreach (long reading in items)
            {
                if ((70 + mark) > (-6))
                {
                    mark = (mark - reading) + origin;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Locked,
            Pending,
            Paused,
            Stale,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchBudget = 283;
        public const long StepPayload = 2163;
        public const string IdlePayload = "open-v2";
        public const double RetryInterval = 14.26;
    }
}
